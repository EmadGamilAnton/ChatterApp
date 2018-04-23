namespace ChattApp
{
    partial class chattForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.myNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myLocalPortTxt = new System.Windows.Forms.TextBox();
            this.myLocalIpTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.friendNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.friendPortTxt = new System.Windows.Forms.TextBox();
            this.friendIpTxt = new System.Windows.Forms.TextBox();
            this.ListMessage = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chooseFriendBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.myNameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.myLocalPortTxt);
            this.groupBox1.Controls.Add(this.myLocalIpTxt);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "My Name :";
            // 
            // myNameTxt
            // 
            this.myNameTxt.Enabled = false;
            this.myNameTxt.Location = new System.Drawing.Point(124, 43);
            this.myNameTxt.Name = "myNameTxt";
            this.myNameTxt.Size = new System.Drawing.Size(207, 24);
            this.myNameTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "My IP :";
            // 
            // myLocalPortTxt
            // 
            this.myLocalPortTxt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLocalPortTxt.Location = new System.Drawing.Point(124, 138);
            this.myLocalPortTxt.Name = "myLocalPortTxt";
            this.myLocalPortTxt.Size = new System.Drawing.Size(87, 28);
            this.myLocalPortTxt.TabIndex = 1;
            // 
            // myLocalIpTxt
            // 
            this.myLocalIpTxt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLocalIpTxt.Location = new System.Drawing.Point(124, 90);
            this.myLocalIpTxt.Name = "myLocalIpTxt";
            this.myLocalIpTxt.Size = new System.Drawing.Size(207, 28);
            this.myLocalIpTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.friendNameTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.friendPortTxt);
            this.groupBox2.Controls.Add(this.friendIpTxt);
            this.groupBox2.Location = new System.Drawing.Point(404, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 193);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend Info";
            // 
            // friendNameTxt
            // 
            this.friendNameTxt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendNameTxt.Location = new System.Drawing.Point(143, 39);
            this.friendNameTxt.Name = "friendNameTxt";
            this.friendNameTxt.Size = new System.Drawing.Size(190, 28);
            this.friendNameTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Friend Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Friend Port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Friend IP :";
            // 
            // friendPortTxt
            // 
            this.friendPortTxt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendPortTxt.Location = new System.Drawing.Point(143, 135);
            this.friendPortTxt.Name = "friendPortTxt";
            this.friendPortTxt.Size = new System.Drawing.Size(95, 28);
            this.friendPortTxt.TabIndex = 1;
            // 
            // friendIpTxt
            // 
            this.friendIpTxt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendIpTxt.Location = new System.Drawing.Point(143, 86);
            this.friendIpTxt.Name = "friendIpTxt";
            this.friendIpTxt.Size = new System.Drawing.Size(190, 28);
            this.friendIpTxt.TabIndex = 0;
            // 
            // ListMessage
            // 
            this.ListMessage.FormattingEnabled = true;
            this.ListMessage.ItemHeight = 16;
            this.ListMessage.Location = new System.Drawing.Point(23, 294);
            this.ListMessage.Name = "ListMessage";
            this.ListMessage.Size = new System.Drawing.Size(1022, 260);
            this.ListMessage.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(23, 576);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(1022, 96);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(920, 633);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(115, 33);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(32, 132);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(207, 38);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start Chatting";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chooseFriendBtn);
            this.groupBox3.Controls.Add(this.startBtn);
            this.groupBox3.Location = new System.Drawing.Point(770, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 193);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "start connection";
            // 
            // chooseFriendBtn
            // 
            this.chooseFriendBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFriendBtn.Location = new System.Drawing.Point(32, 33);
            this.chooseFriendBtn.Name = "chooseFriendBtn";
            this.chooseFriendBtn.Size = new System.Drawing.Size(207, 38);
            this.chooseFriendBtn.TabIndex = 7;
            this.chooseFriendBtn.Text = "Choose Friend";
            this.chooseFriendBtn.UseVisualStyleBackColor = true;
            this.chooseFriendBtn.Click += new System.EventHandler(this.chooseFriendBtn_Click);
            // 
            // chattForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 689);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.ListMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "chattForm";
            this.Text = "Chatter App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myLocalPortTxt;
        private System.Windows.Forms.TextBox myLocalIpTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox friendPortTxt;
        private System.Windows.Forms.TextBox friendIpTxt;
        private System.Windows.Forms.ListBox ListMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox myNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button chooseFriendBtn;
        public System.Windows.Forms.TextBox friendNameTxt;
        public System.Windows.Forms.GroupBox groupBox2;
    }
}

