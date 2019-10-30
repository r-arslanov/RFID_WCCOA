namespace RfidOpcUaForm
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.SecurityR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecentEndpointsLV = new System.Windows.Forms.ListView();
            this.EndpointR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EpSecurity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endpoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Server = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiscoveredServersLV = new System.Windows.Forms.ListView();
            this.DiscoveryTP = new System.Windows.Forms.TabPage();
            this.DiscoveryB = new System.Windows.Forms.Button();
            this.DiscoveryPortTB = new System.Windows.Forms.TextBox();
            this.DiscoveryLBL = new System.Windows.Forms.Label();
            this.DiscoveryUrlTB = new System.Windows.Forms.TextBox();
            this.DiscoveryPortLBL = new System.Windows.Forms.Label();
            this.RecentEndpointsTP = new System.Windows.Forms.TabPage();
            this.UrlTLP = new System.Windows.Forms.TableLayoutPanel();
            this.DiscoveryTLP = new System.Windows.Forms.TableLayoutPanel();
            this.DiscoveryListsTC = new System.Windows.Forms.TabControl();
            this.DiscoveryGB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseB = new System.Windows.Forms.Button();
            this.DisconnectB = new System.Windows.Forms.Button();
            this.ConnectB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectTLP = new System.Windows.Forms.TableLayoutPanel();
            this.ConnectionGB = new System.Windows.Forms.GroupBox();
            this.UriTLP = new System.Windows.Forms.TableLayoutPanel();
            this.SecurityLabel = new System.Windows.Forms.Label();
            this.ServerUrlTB = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ServerSecTB = new System.Windows.Forms.TextBox();
            this.expandAuthCB = new System.Windows.Forms.CheckBox();
            this.AuthenticationGB = new System.Windows.Forms.GroupBox();
            this.AuthenticationTLP = new System.Windows.Forms.TableLayoutPanel();
            this.X509StoreRB = new System.Windows.Forms.RadioButton();
            this.StoreCertificateTB = new System.Windows.Forms.TextBox();
            this.StoreCertificateLabel = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.StorePathLabel = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.StorePathTB = new System.Windows.Forms.TextBox();
            this.X509RB = new System.Windows.Forms.RadioButton();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.CertificateLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AnonymousRB = new System.Windows.Forms.RadioButton();
            this.X509_CertificateTB = new System.Windows.Forms.TextBox();
            this.UserNameRB = new System.Windows.Forms.RadioButton();
            this.BrowseCertificateB = new System.Windows.Forms.Button();
            this.StatusGB = new System.Windows.Forms.GroupBox();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.CreateTT = new System.Windows.Forms.ToolTip(this.components);
            this.DiscoveryTP.SuspendLayout();
            this.RecentEndpointsTP.SuspendLayout();
            this.UrlTLP.SuspendLayout();
            this.DiscoveryTLP.SuspendLayout();
            this.DiscoveryListsTC.SuspendLayout();
            this.DiscoveryGB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ConnectTLP.SuspendLayout();
            this.ConnectionGB.SuspendLayout();
            this.UriTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.AuthenticationGB.SuspendLayout();
            this.AuthenticationTLP.SuspendLayout();
            this.StatusGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SecurityR
            // 
            this.SecurityR.Text = "Security";
            this.SecurityR.Width = 140;
            // 
            // ServerR
            // 
            this.ServerR.Text = "Server";
            this.ServerR.Width = 120;
            // 
            // RecentEndpointsLV
            // 
            this.RecentEndpointsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServerR,
            this.EndpointR,
            this.SecurityR});
            this.RecentEndpointsLV.FullRowSelect = true;
            this.RecentEndpointsLV.HideSelection = false;
            this.RecentEndpointsLV.Location = new System.Drawing.Point(3, 3);
            this.RecentEndpointsLV.MultiSelect = false;
            this.RecentEndpointsLV.Name = "RecentEndpointsLV";
            this.RecentEndpointsLV.Size = new System.Drawing.Size(481, 119);
            this.RecentEndpointsLV.TabIndex = 0;
            this.RecentEndpointsLV.UseCompatibleStateImageBehavior = false;
            this.RecentEndpointsLV.View = System.Windows.Forms.View.Details;
            this.RecentEndpointsLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.RecentEndpointsLV_ItemSelectionChanged);
            // 
            // EndpointR
            // 
            this.EndpointR.Text = "Endpoint";
            this.EndpointR.Width = 220;
            // 
            // EpSecurity
            // 
            this.EpSecurity.Text = "Security";
            this.EpSecurity.Width = 140;
            // 
            // Endpoint
            // 
            this.Endpoint.Text = "Endpoint";
            this.Endpoint.Width = 220;
            // 
            // Server
            // 
            this.Server.Text = "Server";
            this.Server.Width = 120;
            // 
            // DiscoveredServersLV
            // 
            this.DiscoveredServersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Server,
            this.Endpoint,
            this.EpSecurity});
            this.DiscoveredServersLV.FullRowSelect = true;
            this.DiscoveredServersLV.HideSelection = false;
            this.DiscoveredServersLV.Location = new System.Drawing.Point(3, 3);
            this.DiscoveredServersLV.Name = "DiscoveredServersLV";
            this.DiscoveredServersLV.Size = new System.Drawing.Size(481, 119);
            this.DiscoveredServersLV.TabIndex = 1;
            this.DiscoveredServersLV.UseCompatibleStateImageBehavior = false;
            this.DiscoveredServersLV.View = System.Windows.Forms.View.Details;
            this.DiscoveredServersLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DiscoveredServersLV_ItemSelectionChanged);
            // 
            // DiscoveryTP
            // 
            this.DiscoveryTP.Controls.Add(this.DiscoveredServersLV);
            this.DiscoveryTP.Location = new System.Drawing.Point(4, 22);
            this.DiscoveryTP.Name = "DiscoveryTP";
            this.DiscoveryTP.Padding = new System.Windows.Forms.Padding(3);
            this.DiscoveryTP.Size = new System.Drawing.Size(487, 200);
            this.DiscoveryTP.TabIndex = 0;
            this.DiscoveryTP.Text = "Discovery";
            this.DiscoveryTP.UseVisualStyleBackColor = true;
            // 
            // DiscoveryB
            // 
            this.DiscoveryB.AutoSize = true;
            this.DiscoveryB.Location = new System.Drawing.Point(302, 3);
            this.DiscoveryB.Name = "DiscoveryB";
            this.DiscoveryB.Size = new System.Drawing.Size(59, 23);
            this.DiscoveryB.TabIndex = 9;
            this.DiscoveryB.Text = "Discover";
            this.DiscoveryB.UseVisualStyleBackColor = true;
            this.DiscoveryB.Click += new System.EventHandler(this.DiscoveryB_Click);
            // 
            // DiscoveryPortTB
            // 
            this.DiscoveryPortTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscoveryPortTB.Location = new System.Drawing.Point(245, 5);
            this.DiscoveryPortTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.DiscoveryPortTB.Name = "DiscoveryPortTB";
            this.DiscoveryPortTB.Size = new System.Drawing.Size(51, 20);
            this.DiscoveryPortTB.TabIndex = 8;
            this.DiscoveryPortTB.Text = "4840";
            // 
            // DiscoveryLBL
            // 
            this.DiscoveryLBL.AutoSize = true;
            this.DiscoveryLBL.Location = new System.Drawing.Point(3, 5);
            this.DiscoveryLBL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.DiscoveryLBL.Name = "DiscoveryLBL";
            this.DiscoveryLBL.Size = new System.Drawing.Size(45, 13);
            this.DiscoveryLBL.TabIndex = 2;
            this.DiscoveryLBL.Text = "Address";
            // 
            // DiscoveryUrlTB
            // 
            this.DiscoveryUrlTB.Location = new System.Drawing.Point(54, 5);
            this.DiscoveryUrlTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.DiscoveryUrlTB.Name = "DiscoveryUrlTB";
            this.DiscoveryUrlTB.Size = new System.Drawing.Size(153, 20);
            this.DiscoveryUrlTB.TabIndex = 6;
            this.DiscoveryUrlTB.Text = "192.168.0.254";
            // 
            // DiscoveryPortLBL
            // 
            this.DiscoveryPortLBL.AutoSize = true;
            this.DiscoveryPortLBL.Location = new System.Drawing.Point(213, 5);
            this.DiscoveryPortLBL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.DiscoveryPortLBL.Name = "DiscoveryPortLBL";
            this.DiscoveryPortLBL.Size = new System.Drawing.Size(26, 13);
            this.DiscoveryPortLBL.TabIndex = 3;
            this.DiscoveryPortLBL.Text = "Port";
            // 
            // RecentEndpointsTP
            // 
            this.RecentEndpointsTP.Controls.Add(this.RecentEndpointsLV);
            this.RecentEndpointsTP.Location = new System.Drawing.Point(4, 22);
            this.RecentEndpointsTP.Name = "RecentEndpointsTP";
            this.RecentEndpointsTP.Padding = new System.Windows.Forms.Padding(3);
            this.RecentEndpointsTP.Size = new System.Drawing.Size(487, 200);
            this.RecentEndpointsTP.TabIndex = 1;
            this.RecentEndpointsTP.Text = "Recently Used";
            this.RecentEndpointsTP.UseVisualStyleBackColor = true;
            // 
            // UrlTLP
            // 
            this.UrlTLP.ColumnCount = 5;
            this.UrlTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UrlTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UrlTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UrlTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UrlTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UrlTLP.Controls.Add(this.DiscoveryPortTB, 3, 0);
            this.UrlTLP.Controls.Add(this.DiscoveryLBL, 0, 0);
            this.UrlTLP.Controls.Add(this.DiscoveryPortLBL, 2, 0);
            this.UrlTLP.Controls.Add(this.DiscoveryUrlTB, 1, 0);
            this.UrlTLP.Controls.Add(this.DiscoveryB, 4, 0);
            this.UrlTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlTLP.Location = new System.Drawing.Point(3, 3);
            this.UrlTLP.Name = "UrlTLP";
            this.UrlTLP.RowCount = 1;
            this.UrlTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UrlTLP.Size = new System.Drawing.Size(495, 32);
            this.UrlTLP.TabIndex = 3;
            // 
            // DiscoveryTLP
            // 
            this.DiscoveryTLP.ColumnCount = 1;
            this.DiscoveryTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DiscoveryTLP.Controls.Add(this.UrlTLP, 0, 0);
            this.DiscoveryTLP.Controls.Add(this.DiscoveryListsTC, 0, 1);
            this.DiscoveryTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscoveryTLP.Location = new System.Drawing.Point(3, 16);
            this.DiscoveryTLP.Name = "DiscoveryTLP";
            this.DiscoveryTLP.RowCount = 2;
            this.DiscoveryTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.DiscoveryTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.DiscoveryTLP.Size = new System.Drawing.Size(501, 182);
            this.DiscoveryTLP.TabIndex = 1;
            // 
            // DiscoveryListsTC
            // 
            this.DiscoveryListsTC.Controls.Add(this.DiscoveryTP);
            this.DiscoveryListsTC.Controls.Add(this.RecentEndpointsTP);
            this.DiscoveryListsTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscoveryListsTC.Location = new System.Drawing.Point(3, 41);
            this.DiscoveryListsTC.Name = "DiscoveryListsTC";
            this.DiscoveryListsTC.SelectedIndex = 0;
            this.DiscoveryListsTC.Size = new System.Drawing.Size(495, 226);
            this.DiscoveryListsTC.TabIndex = 4;
            // 
            // DiscoveryGB
            // 
            this.DiscoveryGB.AutoSize = true;
            this.DiscoveryGB.Controls.Add(this.DiscoveryTLP);
            this.DiscoveryGB.Location = new System.Drawing.Point(3, 3);
            this.DiscoveryGB.Name = "DiscoveryGB";
            this.DiscoveryGB.Size = new System.Drawing.Size(507, 201);
            this.DiscoveryGB.TabIndex = 3;
            this.DiscoveryGB.TabStop = false;
            this.DiscoveryGB.Text = "Discovery";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 210);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 374);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.Controls.Add(this.CloseB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DisconnectB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ConnectB, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 342);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CloseB
            // 
            this.CloseB.Location = new System.Drawing.Point(420, 3);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(74, 23);
            this.CloseB.TabIndex = 4;
            this.CloseB.Text = "Close";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // DisconnectB
            // 
            this.DisconnectB.Enabled = false;
            this.DisconnectB.Location = new System.Drawing.Point(83, 3);
            this.DisconnectB.Name = "DisconnectB";
            this.DisconnectB.Size = new System.Drawing.Size(75, 23);
            this.DisconnectB.TabIndex = 5;
            this.DisconnectB.Text = "Disconnect";
            this.DisconnectB.UseVisualStyleBackColor = true;
            this.DisconnectB.Click += new System.EventHandler(this.DisconnectB_Click);
            // 
            // ConnectB
            // 
            this.ConnectB.Location = new System.Drawing.Point(3, 3);
            this.ConnectB.Name = "ConnectB";
            this.ConnectB.Size = new System.Drawing.Size(74, 23);
            this.ConnectB.TabIndex = 6;
            this.ConnectB.Text = "Connect";
            this.ConnectB.UseVisualStyleBackColor = true;
            this.ConnectB.Click += new System.EventHandler(this.ConnectB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConnectTLP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 333);
            this.panel1.TabIndex = 1;
            // 
            // ConnectTLP
            // 
            this.ConnectTLP.AutoSize = true;
            this.ConnectTLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectTLP.ColumnCount = 1;
            this.ConnectTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConnectTLP.Controls.Add(this.ConnectionGB, 0, 0);
            this.ConnectTLP.Controls.Add(this.AuthenticationGB, 0, 1);
            this.ConnectTLP.Controls.Add(this.StatusGB, 0, 2);
            this.ConnectTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectTLP.Location = new System.Drawing.Point(0, 0);
            this.ConnectTLP.MinimumSize = new System.Drawing.Size(370, 331);
            this.ConnectTLP.Name = "ConnectTLP";
            this.ConnectTLP.RowCount = 4;
            this.ConnectTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ConnectTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ConnectTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ConnectTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ConnectTLP.Size = new System.Drawing.Size(501, 333);
            this.ConnectTLP.TabIndex = 17;
            // 
            // ConnectionGB
            // 
            this.ConnectionGB.AutoSize = true;
            this.ConnectionGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectionGB.Controls.Add(this.UriTLP);
            this.ConnectionGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionGB.Location = new System.Drawing.Point(3, 3);
            this.ConnectionGB.Name = "ConnectionGB";
            this.ConnectionGB.Size = new System.Drawing.Size(495, 92);
            this.ConnectionGB.TabIndex = 0;
            this.ConnectionGB.TabStop = false;
            this.ConnectionGB.Text = "Connection Info";
            // 
            // UriTLP
            // 
            this.UriTLP.AutoSize = true;
            this.UriTLP.ColumnCount = 2;
            this.UriTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UriTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UriTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UriTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UriTLP.Controls.Add(this.SecurityLabel, 0, 1);
            this.UriTLP.Controls.Add(this.ServerUrlTB, 1, 0);
            this.UriTLP.Controls.Add(this.UrlLabel, 0, 0);
            this.UriTLP.Controls.Add(this.splitContainer1, 1, 1);
            this.UriTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UriTLP.Location = new System.Drawing.Point(3, 16);
            this.UriTLP.Name = "UriTLP";
            this.UriTLP.RowCount = 2;
            this.UriTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UriTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UriTLP.Size = new System.Drawing.Size(489, 73);
            this.UriTLP.TabIndex = 17;
            // 
            // SecurityLabel
            // 
            this.SecurityLabel.AutoSize = true;
            this.SecurityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecurityLabel.Location = new System.Drawing.Point(3, 26);
            this.SecurityLabel.Name = "SecurityLabel";
            this.SecurityLabel.Size = new System.Drawing.Size(63, 47);
            this.SecurityLabel.TabIndex = 4;
            this.SecurityLabel.Text = "Security";
            this.SecurityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServerUrlTB
            // 
            this.ServerUrlTB.AllowDrop = true;
            this.ServerUrlTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServerUrlTB.Enabled = false;
            this.ServerUrlTB.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerUrlTB.Location = new System.Drawing.Point(74, 3);
            this.ServerUrlTB.Margin = new System.Windows.Forms.Padding(1, 3, 1, 4);
            this.ServerUrlTB.Name = "ServerUrlTB";
            this.ServerUrlTB.Size = new System.Drawing.Size(409, 19);
            this.ServerUrlTB.TabIndex = 1;
            this.ServerUrlTB.Text = "opc.tcp://";
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlLabel.Location = new System.Drawing.Point(3, 0);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(63, 26);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "Server URL";
            this.UrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(72, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ServerSecTB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.expandAuthCB);
            this.splitContainer1.Size = new System.Drawing.Size(413, 41);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.TabStop = false;
            // 
            // ServerSecTB
            // 
            this.ServerSecTB.AllowDrop = true;
            this.ServerSecTB.Enabled = false;
            this.ServerSecTB.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerSecTB.Location = new System.Drawing.Point(2, 11);
            this.ServerSecTB.Margin = new System.Windows.Forms.Padding(1, 3, 1, 4);
            this.ServerSecTB.Name = "ServerSecTB";
            this.ServerSecTB.Size = new System.Drawing.Size(232, 19);
            this.ServerSecTB.TabIndex = 2;
            // 
            // expandAuthCB
            // 
            this.expandAuthCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.expandAuthCB.Appearance = System.Windows.Forms.Appearance.Button;
            this.expandAuthCB.Location = new System.Drawing.Point(35, 5);
            this.expandAuthCB.Name = "expandAuthCB";
            this.expandAuthCB.Size = new System.Drawing.Size(136, 30);
            this.expandAuthCB.TabIndex = 20;
            this.expandAuthCB.Text = "▼ AuthenticationSettings";
            this.expandAuthCB.UseVisualStyleBackColor = true;
            this.expandAuthCB.CheckedChanged += new System.EventHandler(this.expandAuthCB_CheckedChanged);
            // 
            // AuthenticationGB
            // 
            this.AuthenticationGB.AutoSize = true;
            this.AuthenticationGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AuthenticationGB.Controls.Add(this.AuthenticationTLP);
            this.AuthenticationGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthenticationGB.Location = new System.Drawing.Point(3, 101);
            this.AuthenticationGB.Name = "AuthenticationGB";
            this.AuthenticationGB.Size = new System.Drawing.Size(495, 167);
            this.AuthenticationGB.TabIndex = 0;
            this.AuthenticationGB.TabStop = false;
            this.AuthenticationGB.Text = "Authentication Settings";
            // 
            // AuthenticationTLP
            // 
            this.AuthenticationTLP.AutoSize = true;
            this.AuthenticationTLP.ColumnCount = 4;
            this.AuthenticationTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AuthenticationTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AuthenticationTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AuthenticationTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AuthenticationTLP.Controls.Add(this.X509StoreRB, 0, 5);
            this.AuthenticationTLP.Controls.Add(this.StoreCertificateTB, 2, 6);
            this.AuthenticationTLP.Controls.Add(this.StoreCertificateLabel, 1, 6);
            this.AuthenticationTLP.Controls.Add(this.UserNameTB, 2, 2);
            this.AuthenticationTLP.Controls.Add(this.StorePathLabel, 1, 5);
            this.AuthenticationTLP.Controls.Add(this.PasswordTB, 2, 3);
            this.AuthenticationTLP.Controls.Add(this.StorePathTB, 2, 5);
            this.AuthenticationTLP.Controls.Add(this.X509RB, 0, 4);
            this.AuthenticationTLP.Controls.Add(this.UserNameLabel, 1, 2);
            this.AuthenticationTLP.Controls.Add(this.CertificateLabel, 1, 4);
            this.AuthenticationTLP.Controls.Add(this.PasswordLabel, 1, 3);
            this.AuthenticationTLP.Controls.Add(this.AnonymousRB, 0, 1);
            this.AuthenticationTLP.Controls.Add(this.X509_CertificateTB, 2, 4);
            this.AuthenticationTLP.Controls.Add(this.UserNameRB, 0, 2);
            this.AuthenticationTLP.Controls.Add(this.BrowseCertificateB, 3, 4);
            this.AuthenticationTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthenticationTLP.Location = new System.Drawing.Point(3, 16);
            this.AuthenticationTLP.Name = "AuthenticationTLP";
            this.AuthenticationTLP.RowCount = 7;
            this.AuthenticationTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AuthenticationTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AuthenticationTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AuthenticationTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AuthenticationTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AuthenticationTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AuthenticationTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AuthenticationTLP.Size = new System.Drawing.Size(489, 148);
            this.AuthenticationTLP.TabIndex = 17;
            // 
            // X509StoreRB
            // 
            this.X509StoreRB.AutoSize = true;
            this.X509StoreRB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.X509StoreRB.Enabled = false;
            this.X509StoreRB.Location = new System.Drawing.Point(3, 101);
            this.X509StoreRB.Name = "X509StoreRB";
            this.AuthenticationTLP.SetRowSpan(this.X509StoreRB, 2);
            this.X509StoreRB.Size = new System.Drawing.Size(84, 44);
            this.X509StoreRB.TabIndex = 11;
            this.X509StoreRB.Text = "X509 (Store)";
            this.X509StoreRB.UseVisualStyleBackColor = true;
            // 
            // StoreCertificateTB
            // 
            this.AuthenticationTLP.SetColumnSpan(this.StoreCertificateTB, 2);
            this.StoreCertificateTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoreCertificateTB.Enabled = false;
            this.StoreCertificateTB.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreCertificateTB.Location = new System.Drawing.Point(159, 126);
            this.StoreCertificateTB.Name = "StoreCertificateTB";
            this.StoreCertificateTB.Size = new System.Drawing.Size(327, 19);
            this.StoreCertificateTB.TabIndex = 13;
            this.StoreCertificateTB.Text = "SIMATIC_RF600R";
            // 
            // StoreCertificateLabel
            // 
            this.StoreCertificateLabel.AutoSize = true;
            this.StoreCertificateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StoreCertificateLabel.Location = new System.Drawing.Point(93, 123);
            this.StoreCertificateLabel.Name = "StoreCertificateLabel";
            this.StoreCertificateLabel.Size = new System.Drawing.Size(60, 25);
            this.StoreCertificateLabel.TabIndex = 0;
            this.StoreCertificateLabel.Text = "Certificate";
            // 
            // UserNameTB
            // 
            this.AuthenticationTLP.SetColumnSpan(this.UserNameTB, 2);
            this.UserNameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameTB.Enabled = false;
            this.UserNameTB.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTB.Location = new System.Drawing.Point(159, 26);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(327, 19);
            this.UserNameTB.TabIndex = 6;
            // 
            // StorePathLabel
            // 
            this.StorePathLabel.AutoSize = true;
            this.StorePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorePathLabel.Location = new System.Drawing.Point(93, 98);
            this.StorePathLabel.Name = "StorePathLabel";
            this.StorePathLabel.Size = new System.Drawing.Size(60, 25);
            this.StorePathLabel.TabIndex = 0;
            this.StorePathLabel.Text = "Store Path";
            this.StorePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTB
            // 
            this.AuthenticationTLP.SetColumnSpan(this.PasswordTB, 2);
            this.PasswordTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTB.Enabled = false;
            this.PasswordTB.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(159, 51);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '•';
            this.PasswordTB.Size = new System.Drawing.Size(327, 19);
            this.PasswordTB.TabIndex = 7;
            // 
            // StorePathTB
            // 
            this.AuthenticationTLP.SetColumnSpan(this.StorePathTB, 2);
            this.StorePathTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorePathTB.Enabled = false;
            this.StorePathTB.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorePathTB.Location = new System.Drawing.Point(159, 101);
            this.StorePathTB.Name = "StorePathTB";
            this.StorePathTB.Size = new System.Drawing.Size(327, 19);
            this.StorePathTB.TabIndex = 12;
            this.StorePathTB.Text = "LocalMachine\\My";
            // 
            // X509RB
            // 
            this.X509RB.AutoSize = true;
            this.X509RB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.X509RB.Enabled = false;
            this.X509RB.Location = new System.Drawing.Point(3, 76);
            this.X509RB.Name = "X509RB";
            this.X509RB.Size = new System.Drawing.Size(84, 19);
            this.X509RB.TabIndex = 8;
            this.X509RB.Text = "X509 (Dir)";
            this.X509RB.UseVisualStyleBackColor = true;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameLabel.Location = new System.Drawing.Point(93, 23);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(60, 25);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CertificateLabel
            // 
            this.CertificateLabel.AutoSize = true;
            this.CertificateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CertificateLabel.Location = new System.Drawing.Point(93, 73);
            this.CertificateLabel.Name = "CertificateLabel";
            this.CertificateLabel.Size = new System.Drawing.Size(60, 25);
            this.CertificateLabel.TabIndex = 0;
            this.CertificateLabel.Text = "Certificate";
            this.CertificateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel.Location = new System.Drawing.Point(93, 48);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 25);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            // 
            // AnonymousRB
            // 
            this.AnonymousRB.AutoSize = true;
            this.AnonymousRB.Checked = true;
            this.AuthenticationTLP.SetColumnSpan(this.AnonymousRB, 4);
            this.AnonymousRB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnonymousRB.Location = new System.Drawing.Point(3, 3);
            this.AnonymousRB.Name = "AnonymousRB";
            this.AnonymousRB.Size = new System.Drawing.Size(483, 17);
            this.AnonymousRB.TabIndex = 4;
            this.AnonymousRB.TabStop = true;
            this.AnonymousRB.Text = "Anonymous";
            this.AnonymousRB.UseVisualStyleBackColor = true;
            this.AnonymousRB.CheckedChanged += new System.EventHandler(this.AnonymousRB_CheckedChanged);
            // 
            // X509_CertificateTB
            // 
            this.X509_CertificateTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.X509_CertificateTB.Enabled = false;
            this.X509_CertificateTB.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X509_CertificateTB.Location = new System.Drawing.Point(159, 76);
            this.X509_CertificateTB.Name = "X509_CertificateTB";
            this.X509_CertificateTB.Size = new System.Drawing.Size(250, 19);
            this.X509_CertificateTB.TabIndex = 9;
            // 
            // UserNameRB
            // 
            this.UserNameRB.AutoSize = true;
            this.UserNameRB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameRB.Location = new System.Drawing.Point(3, 26);
            this.UserNameRB.Name = "UserNameRB";
            this.AuthenticationTLP.SetRowSpan(this.UserNameRB, 2);
            this.UserNameRB.Size = new System.Drawing.Size(84, 44);
            this.UserNameRB.TabIndex = 5;
            this.UserNameRB.Text = "UserName";
            this.UserNameRB.UseVisualStyleBackColor = true;
            this.UserNameRB.CheckedChanged += new System.EventHandler(this.UserNameRB_CheckedChanged);
            // 
            // BrowseCertificateB
            // 
            this.BrowseCertificateB.Enabled = false;
            this.BrowseCertificateB.Location = new System.Drawing.Point(412, 75);
            this.BrowseCertificateB.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.BrowseCertificateB.Name = "BrowseCertificateB";
            this.BrowseCertificateB.Size = new System.Drawing.Size(75, 23);
            this.BrowseCertificateB.TabIndex = 10;
            this.BrowseCertificateB.Text = "...";
            this.BrowseCertificateB.UseVisualStyleBackColor = true;
            // 
            // StatusGB
            // 
            this.StatusGB.AutoSize = true;
            this.StatusGB.Controls.Add(this.ConnectionStatusLabel);
            this.StatusGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusGB.Location = new System.Drawing.Point(3, 274);
            this.StatusGB.Name = "StatusGB";
            this.StatusGB.Size = new System.Drawing.Size(495, 46);
            this.StatusGB.TabIndex = 0;
            this.StatusGB.TabStop = false;
            this.StatusGB.Text = "Connection Status";
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(12, 17);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(73, 13);
            this.ConnectionStatusLabel.TabIndex = 0;
            this.ConnectionStatusLabel.Text = "Disconnected";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 588);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DiscoveryGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(529, 627);
            this.Name = "ConnectForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectForm_FormClosing);
            this.DiscoveryTP.ResumeLayout(false);
            this.RecentEndpointsTP.ResumeLayout(false);
            this.UrlTLP.ResumeLayout(false);
            this.UrlTLP.PerformLayout();
            this.DiscoveryTLP.ResumeLayout(false);
            this.DiscoveryListsTC.ResumeLayout(false);
            this.DiscoveryGB.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ConnectTLP.ResumeLayout(false);
            this.ConnectTLP.PerformLayout();
            this.ConnectionGB.ResumeLayout(false);
            this.ConnectionGB.PerformLayout();
            this.UriTLP.ResumeLayout(false);
            this.UriTLP.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.AuthenticationGB.ResumeLayout(false);
            this.AuthenticationGB.PerformLayout();
            this.AuthenticationTLP.ResumeLayout(false);
            this.AuthenticationTLP.PerformLayout();
            this.StatusGB.ResumeLayout(false);
            this.StatusGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader SecurityR;
        private System.Windows.Forms.ColumnHeader ServerR;
        private System.Windows.Forms.ListView RecentEndpointsLV;
        private System.Windows.Forms.ColumnHeader EndpointR;
        private System.Windows.Forms.ColumnHeader EpSecurity;
        private System.Windows.Forms.ColumnHeader Endpoint;
        private System.Windows.Forms.ColumnHeader Server;
        private System.Windows.Forms.ListView DiscoveredServersLV;
        private System.Windows.Forms.TabPage DiscoveryTP;
        private System.Windows.Forms.Button DiscoveryB;
        private System.Windows.Forms.TextBox DiscoveryPortTB;
        private System.Windows.Forms.Label DiscoveryLBL;
        private System.Windows.Forms.TextBox DiscoveryUrlTB;
        private System.Windows.Forms.Label DiscoveryPortLBL;
        private System.Windows.Forms.TabPage RecentEndpointsTP;
        private System.Windows.Forms.TableLayoutPanel UrlTLP;
        private System.Windows.Forms.TableLayoutPanel DiscoveryTLP;
        private System.Windows.Forms.TabControl DiscoveryListsTC;
        private System.Windows.Forms.GroupBox DiscoveryGB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.Button DisconnectB;
        private System.Windows.Forms.Button ConnectB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel ConnectTLP;
        private System.Windows.Forms.GroupBox ConnectionGB;
        private System.Windows.Forms.TableLayoutPanel UriTLP;
        private System.Windows.Forms.TextBox ServerUrlTB;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.GroupBox AuthenticationGB;
        private System.Windows.Forms.TableLayoutPanel AuthenticationTLP;
        private System.Windows.Forms.RadioButton X509StoreRB;
        private System.Windows.Forms.TextBox StoreCertificateTB;
        private System.Windows.Forms.Label StoreCertificateLabel;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label StorePathLabel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox StorePathTB;
        private System.Windows.Forms.RadioButton X509RB;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label CertificateLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.RadioButton AnonymousRB;
        private System.Windows.Forms.TextBox X509_CertificateTB;
        private System.Windows.Forms.RadioButton UserNameRB;
        private System.Windows.Forms.Button BrowseCertificateB;
        private System.Windows.Forms.GroupBox StatusGB;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.ToolTip CreateTT;
        private System.Windows.Forms.Label SecurityLabel;
        private System.Windows.Forms.CheckBox expandAuthCB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox ServerSecTB;
    }
}