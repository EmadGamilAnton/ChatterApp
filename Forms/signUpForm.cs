using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ChattApp
{
    public partial class signUpForm : MetroForm
    {
        Classes.UserClass user = new Classes.UserClass();
        DataTable dt = new DataTable();


        public signUpForm()
        {
            InitializeComponent();
        }

        void Clear_All_Label_Error()
        {
            firstNameError.Text = "";
            lastNameError.Text = "";
            userNameError.Text = "";
            passworError.Text = "";
            retypePasswordError.Text = "";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            dt = user.Verify_Add_New_user(userNameTxt.Text, firstNameTxt.Text, lastNameTxt.Text);
            if (dt.Rows.Count > 0)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "This User Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(firstNameTxt.Text))
                {
                    firstNameError.Text = "Enter Valid First Name";
                    firstNameError.ForeColor = Color.Red;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(lastNameTxt.Text))
                    {
                        lastNameError.Text = "Enter Valid Last Name";
                        lastNameError.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(userNameTxt.Text))
                        {
                            userNameError.Text = "Enter Valid User Name";
                            userNameError.ForeColor = Color.Red;
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(userPasswordTxt.Text))
                            {
                                passworError.Text = "Pssword Must Be 8 or more Char";
                                passworError.ForeColor = Color.Red;
                            }
                            else
                            {
                                if (userPasswordTxt.Text != retypeUserPasswordTxt.Text)
                                {
                                    retypePasswordError.Text = "Password Dose Not Matched";
                                }
                                else
                                {
                                    user.Register_User(userNameTxt.Text, firstNameTxt.Text, lastNameTxt.Text, userPasswordTxt.Text);
                                   dt= user.get_Last_User_ID();
                                    this.getLastIDtxt.Text = dt.Rows[0][0].ToString();
                                   // user.InsertStatusForFirstTime(Convert.ToInt32(dt.Rows[0][0]), 0);
                                    MessageBox.Show("user register successfully");
                                    Clear_All_Label_Error();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void firstNameTxt_Validated(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(firstNameTxt.Text))
            {
                firstNameError.Text = "Enter Valid First Name";
                firstNameError.ForeColor = Color.Red;
            }
            else
            {
                firstNameError.Text = "Ok";
                firstNameError.ForeColor = Color.Green;

            }
        }

        private void lastNameTxt_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(lastNameTxt.Text))
            {
                lastNameError.Text = "Enter Valid Last Name";
                lastNameError.ForeColor = Color.Red;
            }
            else
            {
                lastNameError.Text = "Ok";
                lastNameError.ForeColor = Color.Green;
            }
        }

        private void userNameTxt_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userNameTxt.Text))
            {
                userNameError.Text = "Enter Valid User Name";
                userNameError.ForeColor = Color.Red;
            }
            else
            {
               // dt = user.Verify_Add_New_user(userNameTxt.Text, firstNameTxt.Text, lastNameTxt.Text);
              ///  if (dt.Rows.Count > 0)
              //  {
               //     MessageBox.Show("Enter Different User Name,first name and last name", "username error",MessageBoxButtons.OK,MessageBoxIcon.Information);
               //     userNameTxt.SelectAll();
                //    userNameTxt.Focus();
               // }
               // else
               // {
                    userNameError.Text = "Ok";
                    userNameError.ForeColor = Color.Green;
               // }
                
                
            }
        }

        private void userPasswordTxt_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userPasswordTxt.Text) || userPasswordTxt.TextLength < 8)
            {
                passworError.Text = "Pssword Must Be 8 or more Char";
                passworError.ForeColor = Color.Red;
            }
            else
            {

                passworError.Text = "Ok";
                passworError.ForeColor = Color.Green;
            }
        }

        private void retypeUserPasswordTxt_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(retypeUserPasswordTxt.Text) || userPasswordTxt.Text != retypeUserPasswordTxt.Text)
            {
                retypePasswordError.Text = "Password Dose Not Matched";
                retypePasswordError.ForeColor = Color.Red;
            }
            else
            {
                retypePasswordError.Text = "Matched";
                retypePasswordError.ForeColor = Color.Green;
            }
        }

        
    }
}
