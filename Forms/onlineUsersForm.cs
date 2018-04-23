using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ChattApp.Forms
{
    public partial class onlineUsersForm : MetroForm
    {
        Classes.UserClass obj = new Classes.UserClass();
        DataTable dt = new DataTable();
        public onlineUsersForm()
        {
            InitializeComponent();
            dt = obj.Get_Online_Users(Program.userID);
            dataGridViewOnlineUsers.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGridViewOnlineUsers.DataSource = null;
            dt = obj.Get_Online_Users(Program.userID);
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no online Friends", "Online Friends", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else
            {
                dataGridViewOnlineUsers.DataSource = dt;
            }
        }
    }
}
