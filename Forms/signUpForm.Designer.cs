namespace ChattApp
{
    partial class signUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userPasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.retypeUserPasswordTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerBtn = new DevExpress.XtraEditors.SimpleButton();
            this.exitBTN = new DevExpress.XtraEditors.SimpleButton();
            this.firstNameError = new System.Windows.Forms.Label();
            this.lastNameError = new System.Windows.Forms.Label();
            this.userNameError = new System.Windows.Forms.Label();
            this.passworError = new System.Windows.Forms.Label();
            this.retypePasswordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(204, 234);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(308, 24);
            this.userNameTxt.TabIndex = 2;
            this.userNameTxt.Validated += new System.EventHandler(this.userNameTxt_Validated);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(204, 118);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(308, 24);
            this.firstNameTxt.TabIndex = 0;
            this.firstNameTxt.Validated += new System.EventHandler(this.firstNameTxt_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name :";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(204, 174);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(308, 24);
            this.lastNameTxt.TabIndex = 1;
            this.lastNameTxt.Validated += new System.EventHandler(this.lastNameTxt_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name :";
            // 
            // userPasswordTxt
            // 
            this.userPasswordTxt.Location = new System.Drawing.Point(204, 292);
            this.userPasswordTxt.Name = "userPasswordTxt";
            this.userPasswordTxt.PasswordChar = '*';
            this.userPasswordTxt.Size = new System.Drawing.Size(308, 24);
            this.userPasswordTxt.TabIndex = 3;
            this.userPasswordTxt.Validated += new System.EventHandler(this.userPasswordTxt_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password :";
            // 
            // retypeUserPasswordTxt
            // 
            this.retypeUserPasswordTxt.Location = new System.Drawing.Point(204, 342);
            this.retypeUserPasswordTxt.Name = "retypeUserPasswordTxt";
            this.retypeUserPasswordTxt.PasswordChar = '*';
            this.retypeUserPasswordTxt.Size = new System.Drawing.Size(308, 24);
            this.retypeUserPasswordTxt.TabIndex = 4;
            this.retypeUserPasswordTxt.Validated += new System.EventHandler(this.retypeUserPasswordTxt_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Retype Password :";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(366, 398);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(123, 33);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(516, 398);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(123, 33);
            this.exitBTN.TabIndex = 6;
            this.exitBTN.Text = "Cancel";
            this.exitBTN.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // firstNameError
            // 
            this.firstNameError.AutoSize = true;
            this.firstNameError.Location = new System.Drawing.Point(529, 122);
            this.firstNameError.Name = "firstNameError";
            this.firstNameError.Size = new System.Drawing.Size(0, 17);
            this.firstNameError.TabIndex = 9;
            // 
            // lastNameError
            // 
            this.lastNameError.AutoSize = true;
            this.lastNameError.Location = new System.Drawing.Point(529, 171);
            this.lastNameError.Name = "lastNameError";
            this.lastNameError.Size = new System.Drawing.Size(0, 17);
            this.lastNameError.TabIndex = 10;
            // 
            // userNameError
            // 
            this.userNameError.AutoSize = true;
            this.userNameError.Location = new System.Drawing.Point(529, 231);
            this.userNameError.Name = "userNameError";
            this.userNameError.Size = new System.Drawing.Size(0, 17);
            this.userNameError.TabIndex = 11;
            // 
            // passworError
            // 
            this.passworError.AutoSize = true;
            this.passworError.Location = new System.Drawing.Point(529, 289);
            this.passworError.Name = "passworError";
            this.passworError.Size = new System.Drawing.Size(0, 17);
            this.passworError.TabIndex = 12;
            // 
            // retypePasswordError
            // 
            this.retypePasswordError.AutoSize = true;
            this.retypePasswordError.Location = new System.Drawing.Point(529, 342);
            this.retypePasswordError.Name = "retypePasswordError";
            this.retypePasswordError.Size = new System.Drawing.Size(0, 17);
            this.retypePasswordError.TabIndex = 13;
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 472);
            this.Controls.Add(this.retypePasswordError);
            this.Controls.Add(this.passworError);
            this.Controls.Add(this.userNameError);
            this.Controls.Add(this.lastNameError);
            this.Controls.Add(this.firstNameError);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.retypeUserPasswordTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userPasswordTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "signUpForm";
            this.Resizable = false;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox retypeUserPasswordTxt;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton registerBtn;
        private DevExpress.XtraEditors.SimpleButton exitBTN;
        private System.Windows.Forms.Label firstNameError;
        private System.Windows.Forms.Label lastNameError;
        private System.Windows.Forms.Label userNameError;
        private System.Windows.Forms.Label passworError;
        private System.Windows.Forms.Label retypePasswordError;
    }
}