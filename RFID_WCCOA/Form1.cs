using Opc.Ua;
using Opc.Ua.Client;
using RfidOpcUaForm;
using Siemens.UAClientHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RFID_WCCOA
{
    public partial class Form1 : Form
    {
        #region Fields
        private Session mySession;
        private UAClientHelperAPI myHelperApi;
        private Subscription mySubscription;
        private Subscription myEventSubscription;
        private ushort myRfidNamespaceIndex;
        private UARfidMethodIdentifiers myRfidMethodIdentifiers;
        private ListViewNF SubscriptionListView;
        private ListViewNF EventDataLV;
        private XmlDocument myDoc;
        #endregion

        public Form1()
        {
            InitializeComponent();

            myHelperApi = new UAClientHelperAPI();
            //Create new overridden ListViews
            EventDataLV = new ListViewNF();
            //   DrowEventDataListView();
            SubscriptionListView = new ListViewNF();
            //   DrowSubscriptionListView();

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            myHelperApi.ItemChangedNotification -= new MonitoredItemNotificationEventHandler(Notification_MonitoredItem);
            myHelperApi.ItemEventNotification -= new MonitoredItemNotificationEventHandler(Notification_EventItem);
            myHelperApi.KeepAliveNotification -= new KeepAliveEventHandler(Notification_KeepAlive);

            myHelperApi.CertificateValidationNotification += new CertificateValidationEventHandler(Notification_ServerCertificate);
            myHelperApi.KeepAliveNotification += new KeepAliveEventHandler(Notification_KeepAlive);

            string url = "opc.tcp://" + txtIpPort.Text + "/";
            EndpointDescription eds = new EndpointDescription(url);

            try
            {
                myHelperApi.Connect(eds, true, false, "", "").Wait();
                txtIpPort.BackColor = Color.Green;
                MessageBox.Show("Connection Success", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Connection Error", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIpPort.BackColor = Color.Red;

            }

            mySession = myHelperApi.Session;
            if (mySession != null && mySession.Connected)
            {
                Debug.WriteLine("Session success connected");
                try
                {
                    mySubscription = myHelperApi.Subscribe(1000);
                    myEventSubscription = myHelperApi.Subscribe(1000);
                }
                catch
                {
                    Debug.WriteLine("Error subscribe connection");
                }
                myHelperApi.CertificateValidationNotification -= new CertificateValidationEventHandler(Notification_ServerCertificate);
                myHelperApi.KeepAliveNotification -= new KeepAliveEventHandler(Notification_KeepAlive);

                myHelperApi.ItemChangedNotification += new MonitoredItemNotificationEventHandler(Notification_MonitoredItem);
                myHelperApi.ItemEventNotification += new MonitoredItemNotificationEventHandler(Notification_EventItem);
                myHelperApi.KeepAliveNotification += new KeepAliveEventHandler(Notification_KeepAlive);


                myRfidNamespaceIndex = GetRfidNamespaceIndex();
                myRfidMethodIdentifiers = new UARfidMethodIdentifiers(myHelperApi);
            }
        }

        private void stpScnBtn_Click(object sender, EventArgs e)
        {
            NodeId methodNodeId = null;
            NodeId objectNodeId = null;

            methodNodeId = new NodeId(myRfidMethodIdentifiers.MethodIdList[0].Find(x => x.method == MethodToCall.ScanStop).methodNodeId, myRfidNamespaceIndex);
            objectNodeId = new NodeId(myRfidMethodIdentifiers.MethodIdList[0].Find(x => x.method == MethodToCall.ScanStop).objectNodeId, myRfidNamespaceIndex);

            IList<object> callResult = new List<object>();



            try
            {
                callResult = myHelperApi.Session.Call(objectNodeId, methodNodeId, null);
                Debug.WriteLine("---------------------- Success call stopScan method ----------------------");
            }
            catch
            {
                Debug.WriteLine("---------------------- Error call stopScan method ----------------------");
            }
        }
        
        private void strtScnBtn_Click(object sender, EventArgs e)
        {
            NodeId methodNodeId = null;
            NodeId objectNodeId = null;

            methodNodeId = new NodeId(myRfidMethodIdentifiers.MethodIdList[0].Find(x => x.method == MethodToCall.ScanStart).methodNodeId, myRfidNamespaceIndex);
            objectNodeId = new NodeId(myRfidMethodIdentifiers.MethodIdList[0].Find(x => x.method == MethodToCall.ScanStart).objectNodeId, myRfidNamespaceIndex);

            IList<object> callResult = new List<object>();
            ScanSettings scanSettings = new ScanSettings
            {
                DataAvailable = false,
                Duration = 0D,
                Cycles = 0
            };

            try
            {
                callResult = myHelperApi.Session.Call(objectNodeId, methodNodeId, scanSettings);
                Debug.WriteLine("---------------------- Success call startScan method ----------------------");
            }
            catch
            {
                Debug.WriteLine("---------------------- Error call startScan method ----------------------");
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            NodeId methodNodeId = null;
            NodeId objectNodeId = null;
            methodNodeId = new NodeId(myRfidMethodIdentifiers.MethodIdList[0].Find(x => x.method == MethodToCall.ReadTag).methodNodeId, myRfidNamespaceIndex);
            objectNodeId = new NodeId(myRfidMethodIdentifiers.MethodIdList[0].Find(x => x.method == MethodToCall.ReadTag).objectNodeId, myRfidNamespaceIndex);

            object[] inpArgs = new object[6];
            IList<object> callResult = new List<object>();
            ScanData scanData = new ScanData();

            inpArgs[0] = scanData;
            inpArgs[1] = "RAW:BYTES";
            inpArgs[2] = (ushort)1;
            inpArgs[3] = (uint)4;
            inpArgs[4] = (uint)12;
            inpArgs[5] = ConvertStringToByteArray("");

            try
            {
                callResult = myHelperApi.Session.Call(objectNodeId, methodNodeId, inpArgs);
                string outputText;

                outputText = "ReadPoint \t = " + "ReadPoint_1" + System.Environment.NewLine +
                    "Time\t\t = " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture) + System.Environment.NewLine +
                    "OpcStatus\t = Good" + System.Environment.NewLine +
                    "AutoIdStatus\t = " + callResult[1].ToString() + System.Environment.NewLine +
                    "Description\t = " + ((AutoIdOperationStatusEnumeration)callResult[1]).ToString();
                if ((AutoIdOperationStatusEnumeration)callResult[1] == 0)
                {
                    outputText += System.Environment.NewLine + "Data" + System.Environment.NewLine + "|" + System.Environment.NewLine;
                    outputText += ConvertByteArrayToString((byte[])callResult[0]).ToUpper();
                    txtRead.Text = ConvertByteArrayToString((byte[])callResult[0]).ToUpper();
                }

                Debug.WriteLine("---------------------- Success call read method ----------------------");
                Debug.WriteLine(outputText);
            }
            catch
            {
                Debug.WriteLine("---------------------- Error call read method ----------------------");
            }
        }

        #region OpcEventHandler
        private void Notification_MonitoredItem(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MonitoredItemNotificationEventHandler(Notification_MonitoredItem), monitoredItem, e);
                return;
            }

            MonitoredItemNotification notification = e.NotificationValue as MonitoredItemNotification;
            if (notification == null)
            {
                return;
            }

            //Seach for item in listview
            bool foundItem = false;
            ListViewItem foundLvItem = new ListViewItem();

            foreach (ListViewItem item in SubscriptionListView.Items)
            {
                if (item.Text == monitoredItem.StartNodeId.ToString())
                {
                    foundItem = true;
                    foundLvItem = item;
                    break;
                }
            }

            //Don't allow double display
            if (!foundItem)
            {
                Node node = myHelperApi.ReadNode(monitoredItem.StartNodeId.ToString());

                ListViewItem lvItem = new ListViewItem(new[] { monitoredItem.StartNodeId.ToString(), monitoredItem.DisplayName,
                    monitoredItem.SamplingInterval.ToString(), notification.Value.Value == null ? "(null)" : notification.Value.Value.ToString(), notification.Value.StatusCode.ToString(),
                    notification.Value.ServerTimestamp.ToString()});
                SubscriptionListView.Items.Add(lvItem).Tag = monitoredItem;
            }
            else
            {
                foundLvItem.SubItems.Clear();
                foundLvItem.Text = monitoredItem.StartNodeId.ToString();
                foundLvItem.SubItems.AddRange(new[] { monitoredItem.DisplayName,
                    monitoredItem.SamplingInterval.ToString(), notification.Value.Value == null ? "(null)" : notification.Value.Value.ToString(), notification.Value.StatusCode.ToString(),
                    notification.Value.ServerTimestamp.ToString()});
            }
        }
        private void Notification_EventItem(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MonitoredItemNotificationEventHandler(Notification_EventItem), monitoredItem, e);
                return;
            }

            if (!(e.NotificationValue is EventFieldList eventFieldList))
            {
                return;
            }

            // Add RfidScanResult to EnvodableFactory to decode event data
            EncodeableFactory.GlobalFactory.AddEncodeableType(typeof(RfidScanResult));
            ExtensionObject[] exObjArr = (ExtensionObject[])eventFieldList.EventFields[4].Value;

            // TBD: Event doen't contain RfidScanResult
            if (exObjArr == null)
            {
                return;
            }

            // Add event data to LV
            ListViewItem item = new ListViewItem(new[] { ((DateTime)eventFieldList.EventFields[0].Value).ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture), eventFieldList.EventFields[3].ToString(), eventFieldList.EventFields[2].ToString() });
            EventDataLV.Items.Add(item);


            for (int i = 0; i < exObjArr.Length; i++)
            {
                RfidScanResult rfidScanResult = ExtensionObject.ToEncodeable(exObjArr[i]) as RfidScanResult;

                if (i == 0)
                {
                    EventDataLV.Items[EventDataLV.Items.Count - 1].SubItems.Add("EPCID");
                    EventDataLV.Items[EventDataLV.Items.Count - 1].SubItems.Add(rfidScanResult.ScanData.String);
                }
                else
                {
                    item = new ListViewItem(new[] { "", "", "", "EPCID", rfidScanResult.ScanData.String });
                    EventDataLV.Items.Add(item);
                }
                item = new ListViewItem(new[] { "", "", "", "RSSI", rfidScanResult.Sighting[0].Strength.ToString() });
                EventDataLV.Items.Add(item);
                item = new ListViewItem(new[] { "", "", "", "Power", rfidScanResult.Sighting[0].CurrentPowerLevel.ToString() });
                EventDataLV.Items.Add(item);
                item = new ListViewItem(new[] { "", "", "", "Antenna", rfidScanResult.Sighting[0].Antenna.ToString() });
                EventDataLV.Items.Add(item);
                item = new ListViewItem(new[] { "", "", "", "TimeStamp", rfidScanResult.Sighting[0].Timestamp.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture) });
                EventDataLV.Items.Add(item);
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
                //                UpdateLog("Client", "Lost connection to server; Reconnect failed", false);

                //Release connection
                try
                {
                    myHelperApi.RemoveSubscription(mySubscription);
                }
                catch
                {
                    ;
                }
                myHelperApi.Disconnect();
                mySession = myHelperApi.Session;
                //               ClearUI();
            }
        }
        #endregion

        #region Helper
        public byte[] ConvertStringToByteArray(string hex)
        {
            // If string is not codable caused by the length is not even add a string 0 at the front.
            if (hex.Length % 2 != 0)
            {
                return null;
            }

            int numberChars = hex.Length;

            var bytes = new byte[numberChars / 2];//create a new byteArray with the half of the length of the previous hex

            try
            {
                for (var i = 0; i < numberChars; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);//
                }
                return bytes;
            }
            catch
            {
                return null;
            }
        }

        public string ConvertByteArrayToString(byte[] arr)
        {
            StringBuilder hex = new StringBuilder(arr.Length * 2);
            foreach (byte b in arr)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
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

        private ushort GetRfidNamespaceIndex()
        {
            ushort nameSpaceIndex = 0;

            ReferenceDescriptionCollection refDescCol = new ReferenceDescriptionCollection();
            refDescCol = myHelperApi.BrowseRoot();

            //Browse to variable "AutoIdModelVersion" (mandatory in AutoID) in RfidReaderDeviceType object to find out namespace
            foreach (ReferenceDescription refDescA in refDescCol)
            {
                if (refDescA.BrowseName.Name == "Objects")
                {
                    refDescCol = myHelperApi.BrowseNode(refDescA);
                    foreach (ReferenceDescription refDescB in refDescCol)
                    {
                        if (refDescB.BrowseName.Name == "DeviceSet")
                        {
                            refDescCol = myHelperApi.BrowseNode(refDescB);
                            foreach (ReferenceDescription refDescC in refDescCol)
                            {
                                if (refDescC.TypeDefinition == new ExpandedNodeId(RfidOpcUaForm.AutoID.ObjectTypes.RfidReaderDeviceType, (ushort)myHelperApi.GetNamespaceIndex(RfidOpcUaForm.AutoID.Namespaces.AutoID)))
                                {
                                    refDescCol = myHelperApi.BrowseNode(refDescC);
                                    foreach (ReferenceDescription refDescD in refDescCol)
                                    {
                                        if (refDescD.BrowseName.Name == "AutoIdModelVersion")
                                        {
                                            nameSpaceIndex = refDescD.NodeId.NamespaceIndex;
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }

            return nameSpaceIndex;
        }
        #endregion
    }

    #region Classes
    //Override ListView to get rid of flickering
    class ListViewNF : ListView
    {
        public ListViewNF()
        {
            //Activate double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            //Enable the OnNotifyMessage event so we get a chance to filter out 
            // Windows messages before they get to the form's WndProc
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }
    }
    #endregion 

}
