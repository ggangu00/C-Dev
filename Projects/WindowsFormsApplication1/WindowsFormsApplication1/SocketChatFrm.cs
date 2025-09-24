using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MateClass;

namespace SocketChat
{
    public partial class SocketChatFrm : Form
    {
        TcpClient Client;

        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream stream;

        Thread ReceiveThread;

        bool Connected;

        public SocketChatFrm()
        {
            InitializeComponent();
        }

        private void SocketChatFrm_Load(object sender, EventArgs e)
        {
            cmTextBox_SEND.Focus();

            IPAddress ip = IPAddress.Parse("127.0.0.1");

            Client = new TcpClient();
            Client.Connect(ip, 13000);

            stream = Client.GetStream();
            Connected = true;

            cmTextBox_LOG.AppendText("Connected to Server" + "\r\n");
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

        private void SocketChatFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
        }

        private void Receive()
        {

            while (Connected)
            {
                if (stream.CanRead)
                {
                    string ReceiveData = Reader.ReadLine();
                    if (ReceiveData != null && ReceiveData.Length > 0)
                        cmTextBox_LOG.AppendText("상대 : 연결이 종료되었습니다. \r\n");
                }
            }
        }

    }
}
