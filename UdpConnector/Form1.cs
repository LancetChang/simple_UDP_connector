using System;
using System.Windows.Forms;
using System.Timers;

namespace UdpClient
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer ClientLogRefreshTimer;
        UdpConnector udpClient;

        public Form1()
        {
            InitializeComponent();

            // timer
            ClientLogRefreshTimer = new System.Timers.Timer(500);
            ClientLogRefreshTimer.Elapsed += OnTimedEvent;
            ClientLogRefreshTimer.AutoReset = true;
            ClientLogRefreshTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string log = ConnectorLog.GetInstance().PopItem();
                if (log != null)
                {
                    client_Log.Items.Add(log);
                }
            });
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            udpClient = new UdpConnector();
            udpClient.InitSocket(desIP.Text, Convert.ToInt32(DestinationPort.Text));
        }

        private void SendTest_Click(object sender, EventArgs e)
        {
            if (udpClient == null)
            {
                udpClient = new UdpConnector();
                try
                {
                    int port = Convert.ToInt32(DestinationPort.Text);
                    udpClient.InitSocket(desIP.Text, port);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Application.Exit();
                    return;
                }
            }
            udpClient.SocketSend(SendingText.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientLogRefreshTimer.Enabled = false;
            ClientLogRefreshTimer.Stop();
            ClientLogRefreshTimer.Dispose();

            if (udpClient != null)
            {
                udpClient.SocketQuit();
            }
        }
    }
}
