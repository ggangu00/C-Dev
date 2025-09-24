using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerFrm : Form
    {
        private static ServerFrm instance;
        private TcpListener Server;
        private TcpClient Client = new TcpClient();

        private string ipAddress = "127.0.0.1";
        private int port = 13000;

        StreamReader Reader;
        StreamWriter Writer;

        NetworkStream stream;

        Thread ReceiveThread;

        bool Connected;

        private delegate void AddTextDelegate(string strText);

        public ServerFrm()
        {
            InitializeComponent();
        }

        private void ServerFrm_Load(object sender, EventArgs e)
        {
            Thread ListenThread = new Thread(new ThreadStart(Listen));
            ListenThread.Start();
        }     

        private void Listen()
        {
            AddTextDelegate AddText = new AddTextDelegate(cmTextBox_LOG.AppendText);

            IPAddress localAddr = IPAddress.Parse(ipAddress);
            Server = new TcpListener(localAddr, port);
            Server.Start();

            Client = Server.AcceptTcpClient();
            Connected = true;

            Invoke(AddText, "클라이언트에 연결됨" + "\r\n");

            stream = Client.GetStream();
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);

            ReceiveThread = new Thread(new ThreadStart(Receive));
            ReceiveThread.Start();

        }


        private void cmButton_SEND_Click(object sender, EventArgs e)
        {
            send_Text();
        }

        private void cmTextBox_SEND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                send_Text();
            }
        }

        private void send_Text()
        {
            cmTextBox_LOG.AppendText("나 : " + cmTextBox_SEND.Text + "\r\n");
            Writer.WriteLine(cmTextBox_SEND.Text);
            Writer.Flush();

            cmTextBox_SEND.Clear();

        }

        private void ServerFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            Client.Close();
            Server.Stop();
        }

        private void Receive()
        {
            AddTextDelegate AddText = new AddTextDelegate(cmTextBox_LOG.AppendText);

            while (Connected)
            {
                // stream에 data 있을 경우 
                if (stream.CanRead)
                {
                    string receiveChat = Reader.ReadLine();
                    if (receiveChat != null && receiveChat.Length > 0)
                        Invoke(AddText, "상대 : " + receiveChat + "\r\n");
                }
            }
        }

    }
}
