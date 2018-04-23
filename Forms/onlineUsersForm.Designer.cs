namespace ChattApp.Forms
{
    partial class onlineUsersForm
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
            this.dataGridViewOnlineUsers = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnlineUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOnlineUsers
            // 
            this.dataGridViewOnlineUsers.AllowUserToAddRows = false;
            this.dataGridViewOnlineUsers.AllowUserToDeleteRows = false;
            this.dataGridViewOnlineUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOnlineUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOnlineUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewOnlineUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnlineUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewOnlineUsers.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewOnlineUsers.Location = new System.Drawing.Point(20, 103);
            this.dataGridViewOnlineUsers.Name = "dataGridViewOnlineUsers";
            this.dataGridViewOnlineUsers.ReadOnly = true;
            this.dataGridViewOnlineUsers.RowTemplate.Height = 26;
            this.dataGridViewOnlineUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOnlineUsers.Size = new System.Drawing.Size(925, 265);
            this.dataGridViewOnlineUsers.TabIndex = 0;
            this.dataGridViewOnlineUsers.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(824, 63);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(118, 34);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // onlineUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 388);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dataGridViewOnlineUsers);
            this.Name = "onlineUsersForm";
            this.Text = "Online Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnlineUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button refreshBtn;
        public System.Windows.Forms.DataGridView dataGridViewOnlineUsers;
    }
}