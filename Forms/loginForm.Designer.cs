namespace ChattApp
{
    partial class loginForm
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
            this.loginBTN = new DevExpress.XtraEditors.SimpleButton();
            this.userNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.passwordTxt = new DevExpress.XtraEditors.TextEdit();
            this.exitBTN = new DevExpress.XtraEditors.SimpleButton();
            this.registerForm = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginLabelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(103, 341);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(106, 30);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "SignIn ";
            this.loginBTN.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(103, 211);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(246, 22);
            this.userNameTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(103, 270);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Properties.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(246, 22);
            this.passwordTxt.TabIndex = 1;
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(243, 341);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(106, 30);
            this.exitBTN.TabIndex = 3;
            this.exitBTN.Text = "Exit";
            this.exitBTN.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // registerForm
            // 
            this.registerForm.AutoSize = true;
            this.registerForm.Location = new System.Drawing.Point(253, 398);
            this.registerForm.Name = "registerForm";
            this.registerForm.Size = new System.Drawing.Size(35, 17);
            this.registerForm.TabIndex = 4;
            this.registerForm.TabStop = true;
            this.registerForm.Text = "here";
            this.registerForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Register Click ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // loginLabelError
            // 
            this.loginLabelError.AutoSize = true;
            this.loginLabelError.Location = new System.Drawing.Point(100, 312);
            this.loginLabelError.Name = "loginLabelError";
            this.loginLabelError.Size = new System.Drawing.Size(0, 17);
            this.loginLabelError.TabIndex = 9;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 712);
            this.Controls.Add(this.loginLabelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerForm);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.loginBTN);
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Resizable = false;
            this.Text = "Sign In";
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.userNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton loginBTN;
        private DevExpress.XtraEditors.TextEdit userNameTxt;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private DevExpress.XtraEditors.SimpleButton exitBTN;
        private System.Windows.Forms.LinkLabel registerForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loginLabelError;
    }
}