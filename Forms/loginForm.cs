using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using System.Net.Sockets;

namespace ChattApp
{
    public partial class loginForm : MetroForm
    {
        Classes.UserClass user = new Classes.UserClass();
        DataTable dt = new DataTable();


        public loginForm()
        {
            InitializeComponent();

            userNameTxt.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            signUpForm frm = new signUpForm();
            frm.ShowDialog();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dt = user.User_Login(userNameTxt.Text, passwordTxt.Text);

            if (dt.Rows.Count > 0)
            {
                Program.FullName = dt.Rows[0][1].ToString();
                Program.userID =Convert.ToInt32( dt.Rows[0][0].ToString());
                loginLabelError.Text = "User Login Successfully";
                loginLabelError.ForeColor = Color.Green;

                user.Update_Status( Program.userID,1);
               // obj.Update_Ip(obj2.getLocalIp(), userNameTxt.Text);
                new chattForm().ShowDialog();
            }
            else
            {
                loginLabelError.Text = "User Info Incorrect Try Again";
                loginLabelError.ForeColor = Color.Red;
                userNameTxt.SelectAll();
                userNameTxt.Focus();
            }
        }
       
        private void loginForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    user.Update_Status(Program.userID,0);
                    MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                }
                catch
                {
                    return;
                }

            }else
            {
                
            }
        }
    }
    
}
