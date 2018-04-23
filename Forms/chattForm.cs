using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ChattApp
{
    public partial class chattForm : MetroForm
    {
        Socket soket;
        EndPoint epLocal, epRemote;
        public string me = "Me";
       
        public chattForm()
        {
            InitializeComponent();
            myNameTxt.Text = Program.FullName;
           
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            soket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            myLocalIpTxt.Text = getLocalIp();         
        }
        public string getLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }

            }
            return "127.0.0.1";
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = soket.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] recivedData = new byte[1500];
                    recivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recivedMessage = eEncoding.GetString(recivedData);
                    string friend = friendNameTxt.Text;
                    ListMessage.Items.Add(friend+" : " + recivedMessage);
                }
                byte[] buffer = new byte[1500];
                soket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(myLocalIpTxt.Text), Convert.ToInt32(myLocalPortTxt.Text));
                soket.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(friendIpTxt.Text), Convert.ToInt32(friendPortTxt.Text));
                soket.Connect(epRemote);

                byte[] buffer = new byte[1500];
                soket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                startBtn.Text = "Connected";
                txtMessage.Focus();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
            
        } 

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this,new EventArgs());
            }
        }
        
        private void chooseFriendBtn_Click(object sender, EventArgs e)
        {
            Forms.onlineUsersForm frm = new Forms.onlineUsersForm();
            frm.ShowDialog();
            try
            {
            this.friendNameTxt.Text = frm.dataGridViewOnlineUsers.CurrentRow.Cells[0].Value.ToString();
            this.friendIpTxt.Text   = frm.dataGridViewOnlineUsers.CurrentRow.Cells[1].Value.ToString();
            this.friendPortTxt.Text = frm.dataGridViewOnlineUsers.CurrentRow.Cells[2].Value.ToString();

            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                return;
            }
            else
            {
                try
                {
                    ASCIIEncoding enc = new ASCIIEncoding();
                    byte[] msg = new byte[1500];
                    msg = enc.GetBytes(txtMessage.Text);
                  
                    soket.Send(msg);
                    ListMessage.Items.Add(me + " : " + txtMessage.Text);
                    txtMessage.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
