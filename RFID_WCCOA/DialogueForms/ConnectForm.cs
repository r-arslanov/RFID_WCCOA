//=============================================================================
// Siemens AG
// (c)Copyright (2019) All Rights Reserved
//----------------------------------------------------------------------------- 
// Tested with: Windows 10 Enterprise x64
// Engineering: Visual Studio 2017
// Version: 1.0
//=============================================================================

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Opc.Ua;
using Opc.Ua.Client;
using Siemens.UAClientHelper;

namespace RfidOpcUaForm
{
    public partial class ConnectForm : Form
    {
        #region Fields
        private UAClientHelperAPI myHelperApi;
        private EndpointDescription mySelectedEndpoint;
        private Session mySession;
        private XmlDocument myDoc;
    //    public AddLogDelegate AddLogCallback;
        #endregion

        #region Construction
        public ConnectForm(UAClientHelperAPI helperAPI)
        {
            InitializeComponent();

            //Assign OPC UA objects
            myHelperApi = helperAPI;
            mySession = myHelperApi.Session;
            AuthenticationGB.Visible = false;

            //Register mandatory events (cert and keep alive)
            myHelperApi.KeepAliveNotification += new KeepAliveEventHandler(Notification_KeepAlive);
            myHelperApi.CertificateValidationNotification += new CertificateValidationEventHandler(Notification_ServerCertificate);

            //Prepare UI style
            if (mySession != null && mySession.Connected)
            {
                ConnectionStatusLabel.Text = "Connected";
                ConnectionStatusLabel.ForeColor = Color.Green;
                DisconnectB.Enabled = true;
                ConnectB.Enabled = false;
            }

            //Create XML file for saved endpoints
            CreateXmlFile();

            //Retrieve endpoints if available
            RetrieveEndpointsAndPopulateLV();            
        }
        #endregion

        #region UiEvents
        private void expandAuthCB_CheckedChanged(object sender, EventArgs e)
        {
            if (AuthenticationTLP.Visible)
            {
                AuthenticationGB.Visible = false;
                expandAuthCB.Checked = false;
                expandAuthCB.Text = "▼ AuthenticationSettings";
            }
            else
            {
                AuthenticationGB.Visible = true;
                expandAuthCB.Checked = true;
                expandAuthCB.Text = "▲ AuthenticationSettings";
            }
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DiscoveryB_Click(object sender, EventArgs e)
        {
            bool foundEndpoints = false;
            DiscoveredServersLV.Items.Clear();

            //Create discovery URL for the discovery client
            string serverUrl = null;
            if (!String.IsNullOrEmpty(DiscoveryUrlTB.Text) & !String.IsNullOrEmpty(DiscoveryPortTB.Text))
            {
                serverUrl = "opc.tcp://" + DiscoveryUrlTB.Text + ":" + DiscoveryPortTB.Text;
            }
            else if (String.IsNullOrEmpty(DiscoveryUrlTB.Text) & !String.IsNullOrEmpty(DiscoveryPortTB.Text))
            {
                serverUrl = "opc.tcp://localhost:" + DiscoveryPortTB.Text;
            }
            else if (!String.IsNullOrEmpty(DiscoveryUrlTB.Text) & String.IsNullOrEmpty(DiscoveryPortTB.Text))
            {
                serverUrl = "opc.tcp://" + DiscoveryUrlTB.Text + ":" + "4840";
            }
            else
            {
                serverUrl = "opc.tcp://localhost:4840";
            }

            //Get the endpoints
            try
            {
                ApplicationDescriptionCollection servers = myHelperApi.FindServers(serverUrl);
                foreach (ApplicationDescription ad in servers)
                {
                    foreach (string url in ad.DiscoveryUrls)
                    {
                        EndpointDescriptionCollection endpoints = myHelperApi.GetEndpoints(url);
                        foundEndpoints = foundEndpoints || endpoints.Count > 0;
                        foreach (EndpointDescription ep in endpoints)
                        {
                            string securityPolicy = ep.SecurityPolicyUri.Remove(0, 43);
                            if (!DiscoveredServersLV.Items.ContainsKey(ep.Server.ApplicationName.Text))
                            {
                                string[] row = { ep.Server.ApplicationName.Text, ep.EndpointUrl, ep.SecurityMode + "-" + securityPolicy };
                                ListViewItem listViewItem = new ListViewItem(row);
                                DiscoveredServersLV.Items.Add(listViewItem).Tag = ep;
                                DiscoveredServersLV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                            }
                        }
                    }
                    if (!foundEndpoints)
                    {
                        MessageBox.Show("Could not get any Endpoints", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DiscoveredServersLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            mySelectedEndpoint = (EndpointDescription)e.Item.Tag;
            ServerUrlTB.Text = mySelectedEndpoint.EndpointUrl;
            ServerSecTB.Text = mySelectedEndpoint.SecurityMode + "-" + mySelectedEndpoint.SecurityPolicyUri.Remove(0, 43);
        }

        private void RecentEndpointsLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            mySelectedEndpoint = (EndpointDescription)e.Item.Tag;
            ServerUrlTB.Text = mySelectedEndpoint.EndpointUrl;
        }

        private void ConnectB_Click(object sender, EventArgs e)
        {
            //Use connect with endpoint object
            if (mySelectedEndpoint != null)
            {
                try
                {
                    myHelperApi.Connect(mySelectedEndpoint, true, UserNameRB.Checked, UserNameTB.Text, PasswordTB.Text).Wait();

                    mySession = myHelperApi.Session;

                    AddEndpoint(mySelectedEndpoint);                    

                    ConnectionStatusLabel.Text = "Connected";
                    ConnectionStatusLabel.ForeColor = Color.Green;
                    DisconnectB.Enabled = true;
                    ConnectB.Enabled = false;
//                    AddLogCallback("Client", "Connected to " + mySession.Endpoint.Server.ApplicationUri, true);

                    AddListIpConfig(DiscoveryUrlTB.Text, DiscoveryPortTB.Text);

                    RetrieveEndpointsAndPopulateLV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
 //                   AddLogCallback("Client", "Stack error: " + ex.InnerException.Message, false);
                }
            }
            //Use connect without endpoint object
            else
            {
                MessageBox.Show("Please retrieve and selecte Endpoint first.", "Error");
            }

        }

        private void UserNameRB_CheckedChanged(object sender, EventArgs e)
        {
            if (UserNameRB.Checked)
            {
                UserNameTB.Enabled = true;
                PasswordTB.Enabled = true;
            }
        }

        private void AnonymousRB_CheckedChanged(object sender, EventArgs e)
        {
            if (AnonymousRB.Checked)
            {
                UserNameTB.Text = string.Empty;
                PasswordTB.Text = string.Empty;
                UserNameTB.Enabled = false;
                PasswordTB.Enabled = false;
            }
        }

        private void DisconnectB_Click(object sender, EventArgs e)
        {
            string lastServer = myHelperApi.Session.Endpoint.Server.ApplicationUri;         
            myHelperApi.Disconnect();
            mySession = null;
            DisconnectB.Enabled = false;
            ConnectB.Enabled = true;
            ConnectionStatusLabel.Text = "Disconnected";
            ConnectionStatusLabel.ForeColor = Color.Red;
 //           AddLogCallback("Client", "Disconnected from " + lastServer, true);
        }

        private void ConnectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myHelperApi.KeepAliveNotification -= new KeepAliveEventHandler(Notification_KeepAlive);
            myHelperApi.CertificateValidationNotification -= new CertificateValidationEventHandler(Notification_ServerCertificate);
        }
        #endregion

        #region OpcEventHandlers
        private void Notification_ServerCertificate(CertificateValidator cert, CertificateValidationEventArgs e)
        {
            //Handle certificate here
            //To accept a certificate manually move it to the root folder (Start > mmc.exe > add snap-in > certificates)
            //Or handle via UAClientCertForm

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CertificateValidationEventHandler(Notification_ServerCertificate), cert, e);
                return;
            }

            try
            {
                //Always accept
                e.Accept = true;
            }
            catch
            {
                ;
            }
        }
        private void Notification_KeepAlive(Session sender, KeepAliveEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new KeepAliveEventHandler(Notification_KeepAlive), sender, e);
                return;
            }

            // check for events from discarded sessions.
            if (!Object.ReferenceEquals(sender, mySession))
            {
                return;
            }

            // check for disconnected session.
            if (!ServiceResult.IsGood(e.Status))
            {
//                AddLogCallback("Client", "Lost connection to server; Reconnect failed", false);

                //Release connection
                myHelperApi.Disconnect();
                mySession = myHelperApi.Session;
                DisconnectB.Enabled = false;
                ConnectB.Enabled = true;
                ConnectionStatusLabel.Text = "Disconnected";
                ConnectionStatusLabel.ForeColor = Color.Red;
            }
        }
        #endregion

        #region AdditionalMethods
        private void CreateXmlFile()
        {
            myDoc = new XmlDocument();

            if (!File.Exists("Endpoints.xml"))
            {

                XmlElement root = myDoc.CreateElement("Endpoints");
                XmlNode child = myDoc.CreateElement("IpConfig");
                root.AppendChild(child);
                myDoc.AppendChild(root);
                myDoc.Save("Endpoints.xml");
            }

            myDoc.Load("Endpoints.xml");
        }
        public void AddEndpoint(EndpointDescription a_EndpointDesc)
        {
            bool alreadyExists = false;

            XmlNode Endpoints = myDoc.SelectSingleNode("//Endpoints");
            XmlNode newEndpoint = myDoc.CreateNode(XmlNodeType.Element, "Endpoint", null);
            XmlNode url = myDoc.CreateNode(XmlNodeType.Element, "url", null);
            XmlNode security = myDoc.CreateNode(XmlNodeType.Element, "securityMode", null);
            XmlNode serverName = myDoc.CreateNode(XmlNodeType.Element, "serverName", null);

            url.InnerText = a_EndpointDesc.EndpointUrl;
            string[] policy = a_EndpointDesc.SecurityPolicyUri.Split('#');
            security.InnerText = policy[1] + "-" + a_EndpointDesc.SecurityMode.ToString();
            serverName.InnerText = a_EndpointDesc.Server.ApplicationName.ToString();

            if (Endpoints.HasChildNodes)
            {
                XmlNodeList children = Endpoints.SelectNodes("//Endpoint");
                foreach (XmlNode node in children)
                {
                    if (node.SelectSingleNode("url").InnerText == url.InnerText)
                    {
                        if (node.SelectSingleNode("securityMode").InnerText == security.InnerText)
                        {
                            alreadyExists = true;
                        }
                    }
                }

                if (!alreadyExists)
                {
                    if (children.Count > 10)
                    {
                        Endpoints.RemoveChild(Endpoints.FirstChild);
                    }

                    newEndpoint.InsertAfter(url, null);
                    newEndpoint.InsertAfter(security, null);
                    newEndpoint.InsertAfter(serverName, null);
                    Endpoints.InsertAfter(newEndpoint, null);
                    myDoc.Save("Endpoints.xml");
                }
            }
            else
            {
                newEndpoint.InsertAfter(url, null);
                newEndpoint.InsertAfter(security, null);
                newEndpoint.InsertAfter(serverName, null);
                Endpoints.InsertAfter(newEndpoint, null);
                myDoc.Save("Endpoints.xml");
            }
        }
        public void AddListIpConfig(string ipAdr, string portAdr)
        {
            XmlNode EPs = myDoc.SelectSingleNode("//Endpoints");

            if (EPs.HasChildNodes)
            {
                XmlNode children = EPs.SelectSingleNode("//IpConfig");
                XmlNode ip = myDoc.CreateNode(XmlNodeType.Element, "IP", null);
                XmlNode port = myDoc.CreateNode(XmlNodeType.Element, "Port", null);

                if (children.SelectSingleNode("//IP") == null)
                {
                    children.InsertAfter(ip, null);
                    children.InsertAfter(port, null);
                }
                children.SelectSingleNode("IP").InnerText = ipAdr;
                children.SelectSingleNode("Port").InnerText = portAdr;                
            }
            myDoc.Save("Endpoints.xml");
        }
        public void RetrieveEndpointsAndPopulateLV()
        {
            EndpointDescriptionCollection endpointDescCol = new EndpointDescriptionCollection();

            XmlNodeList endpointNodes = myDoc.SelectSingleNode("//Endpoints").SelectNodes("//Endpoint");
            XmlNodeList ipConfig = myDoc.SelectSingleNode("//Endpoints").SelectNodes("//IpConfig");

            foreach (XmlNode node in endpointNodes)
            {
                EndpointDescription epDesc = new EndpointDescription();
                epDesc.EndpointUrl = node.SelectSingleNode("url").InnerText;
                epDesc.Server.ApplicationName = node.SelectSingleNode("serverName").InnerText;
                string[] secMode = node.SelectSingleNode("securityMode").InnerText.Split('-');
                epDesc.SecurityPolicyUri = "http://opcfoundation.org/UA/SecurityPolicy#" + secMode[0];
                if (secMode[1].Equals("SignAndEncrypt"))
                {
                    epDesc.SecurityMode = MessageSecurityMode.SignAndEncrypt;
                }
                else if (secMode[1].Equals("Sign"))
                {
                    epDesc.SecurityMode = MessageSecurityMode.Sign;
                }
                else if (secMode[1].Equals("None"))
                {
                    epDesc.SecurityMode = MessageSecurityMode.None;
                }
                else
                {
                    epDesc.SecurityMode = MessageSecurityMode.Invalid;
                }

                endpointDescCol.Add(epDesc);
            }

            RecentEndpointsLV.Items.Clear();
            foreach (EndpointDescription ep in endpointDescCol)
            {
                string securityPolicy = ep.SecurityPolicyUri.Remove(0, 43);
                string[] row = { ep.Server.ApplicationName.Text, ep.EndpointUrl, ep.SecurityMode + "-" + securityPolicy };
                ListViewItem listViewItem = new ListViewItem(row);
                RecentEndpointsLV.Items.Add(listViewItem).Tag = ep;
                RecentEndpointsLV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            if (ipConfig[0].ChildNodes.Count > 0)
            {
                DiscoveryUrlTB.Text = ipConfig[0].SelectSingleNode("IP").InnerText;
                DiscoveryPortTB.Text = ipConfig[0].SelectSingleNode("Port").InnerText;
            }
        }
        #endregion
    }
}

