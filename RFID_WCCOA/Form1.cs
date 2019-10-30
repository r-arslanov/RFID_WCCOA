using Opc.Ua;
using Opc.Ua.Client;
using RfidOpcUaForm;
using Siemens.UAClientHelper;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Globalization;

namespace RFID_WCCOA
{
    public partial class Form1 : Form
    {
        #region Fields
        private Session mySession;
        private UAClientHelperAPI myHelperApi;
        private Subscription mySubscription;
        private Subscription myEventSubscription;
        private string myLogFilePath;
        private ushort myRfidNamespaceIndex;
        private UARfidMethodIdentifiers myRfidMethodIdentifiers;
        private ListViewNF SubscriptionListView;
        private ListViewNF EventDataLV;
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

            ConnectForm dlg = new ConnectForm(myHelperApi);
            dlg.ShowDialog();
            mySession = myHelperApi.Session;
            if(mySession != null && mySession.Connected)
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
