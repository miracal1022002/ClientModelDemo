using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Drawing.Text;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public string TextToSend;
        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach(IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtextbox.Text = address.ToString();
                }
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPorttextbox.Text));
            listener.Start();   
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            MessageBox.Show("Started server successfully");
        }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IPEnd = new IPEndPoint(IPAddress.Parse(ClientIPtextbox.Text), int.Parse(ClientPorttextbox.Text));
            client.Connect(IPEnd);
            try
            {
                ChatScreentextbox.AppendText("Connected to Server" + "\r\n");
                MessageBox.Show("Connected successfully");
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true; 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.ChatScreentextbox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreentextbox.AppendText("You: " + receive + "\r\n");
                    }));
                    receive = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreentextbox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreentextbox.AppendText("Me: " + TextToSend + "\r\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }

            backgroundWorker2.CancelAsync(); 
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (Messagetextbox.Text!="")
            {
                TextToSend = Messagetextbox.Text;
                backgroundWorker2.RunWorkerAsync();
            } 
            Messagetextbox.Text = "";
        }
    }
}