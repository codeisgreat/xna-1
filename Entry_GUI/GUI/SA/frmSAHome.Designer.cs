namespace Main_XNA_Game.GUI.SA
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabApprove = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoRegUsers = new System.Windows.Forms.Label();
            this.btnConfirmReject = new System.Windows.Forms.Button();
            this.btnConfirmApproved = new System.Windows.Forms.Button();
            this.cblRegRequests = new System.Windows.Forms.CheckedListBox();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.cblUserDetails = new System.Windows.Forms.CheckedListBox();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewGameDetails = new System.Windows.Forms.Button();
            this.cblGameHistory = new System.Windows.Forms.CheckedListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabApprove.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SA administration Panel";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabApprove);
            this.tabControl1.Controls.Add(this.tabEdit);
            this.tabControl1.Controls.Add(this.tabGame);
            this.tabControl1.Location = new System.Drawing.Point(44, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 378);
            this.tabControl1.TabIndex = 6;
            // 
            // tabApprove
            // 
            this.tabApprove.AllowDrop = true;
            this.tabApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabApprove.Controls.Add(this.panel1);
            this.tabApprove.Location = new System.Drawing.Point(4, 22);
            this.tabApprove.Name = "tabApprove";
            this.tabApprove.Padding = new System.Windows.Forms.Padding(3);
            this.tabApprove.Size = new System.Drawing.Size(547, 352);
            this.tabApprove.TabIndex = 0;
            this.tabApprove.Text = "Approve New Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblNoRegUsers);
            this.panel1.Controls.Add(this.btnConfirmReject);
            this.panel1.Controls.Add(this.btnConfirmApproved);
            this.panel1.Controls.Add(this.cblRegRequests);
            this.panel1.Location = new System.Drawing.Point(31, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 298);
            this.panel1.TabIndex = 6;
            // 
            // lblNoRegUsers
            // 
            this.lblNoRegUsers.AutoSize = true;
            this.lblNoRegUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRegUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNoRegUsers.Location = new System.Drawing.Point(40, 15);
            this.lblNoRegUsers.Name = "lblNoRegUsers";
            this.lblNoRegUsers.Size = new System.Drawing.Size(192, 16);
            this.lblNoRegUsers.TabIndex = 6;
            this.lblNoRegUsers.Text = "No New Registration Requests";
            // 
            // btnConfirmReject
            // 
            this.btnConfirmReject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmReject.BackgroundImage")));
            this.btnConfirmReject.FlatAppearance.BorderSize = 0;
            this.btnConfirmReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReject.ForeColor = System.Drawing.Color.LightGreen;
            this.btnConfirmReject.Location = new System.Drawing.Point(245, 224);
            this.btnConfirmReject.Name = "btnConfirmReject";
            this.btnConfirmReject.Size = new System.Drawing.Size(100, 66);
            this.btnConfirmReject.TabIndex = 7;
            this.btnConfirmReject.Text = "Reject";
            this.btnConfirmReject.UseVisualStyleBackColor = true;
            this.btnConfirmReject.Click += new System.EventHandler(this.btnConfirmReject_Click_1);
            // 
            // btnConfirmApproved
            // 
            this.btnConfirmApproved.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmApproved.BackgroundImage")));
            this.btnConfirmApproved.FlatAppearance.BorderSize = 0;
            this.btnConfirmApproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmApproved.ForeColor = System.Drawing.Color.LightGreen;
            this.btnConfirmApproved.Location = new System.Drawing.Point(43, 224);
            this.btnConfirmApproved.Name = "btnConfirmApproved";
            this.btnConfirmApproved.Size = new System.Drawing.Size(100, 66);
            this.btnConfirmApproved.TabIndex = 6;
            this.btnConfirmApproved.Text = "Approve";
            this.btnConfirmApproved.UseVisualStyleBackColor = true;
            this.btnConfirmApproved.Click += new System.EventHandler(this.btnConfirmApproved_Click_1);
            // 
            // cblRegRequests
            // 
            this.cblRegRequests.CheckOnClick = true;
            this.cblRegRequests.FormattingEnabled = true;
            this.cblRegRequests.Location = new System.Drawing.Point(43, 47);
            this.cblRegRequests.Name = "cblRegRequests";
            this.cblRegRequests.Size = new System.Drawing.Size(400, 154);
            this.cblRegRequests.TabIndex = 0;
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabEdit.Controls.Add(this.panel2);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(547, 352);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "User Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnViewUser);
            this.panel2.Controls.Add(this.cblUserDetails);
            this.panel2.Location = new System.Drawing.Point(23, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 310);
            this.panel2.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightGreen;
            this.btnDelete.Location = new System.Drawing.Point(236, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 66);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edit User Details";
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewUser.BackgroundImage")));
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.LightGreen;
            this.btnViewUser.Location = new System.Drawing.Point(43, 224);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(100, 66);
            this.btnViewUser.TabIndex = 6;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.UseVisualStyleBackColor = true;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // cblUserDetails
            // 
            this.cblUserDetails.CheckOnClick = true;
            this.cblUserDetails.FormattingEnabled = true;
            this.cblUserDetails.Location = new System.Drawing.Point(43, 47);
            this.cblUserDetails.Name = "cblUserDetails";
            this.cblUserDetails.Size = new System.Drawing.Size(400, 154);
            this.cblUserDetails.TabIndex = 0;
            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabGame.Controls.Add(this.panel3);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Name = "tabGame";
            this.tabGame.Size = new System.Drawing.Size(547, 352);
            this.tabGame.TabIndex = 2;
            this.tabGame.Text = "Game Statistics";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnDeleteGame);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnViewGameDetails);
            this.panel3.Controls.Add(this.cblGameHistory);
            this.panel3.Location = new System.Drawing.Point(20, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 296);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteGame.BackgroundImage")));
            this.btnDeleteGame.FlatAppearance.BorderSize = 0;
            this.btnDeleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.ForeColor = System.Drawing.Color.LightGreen;
            this.btnDeleteGame.Location = new System.Drawing.Point(234, 224);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(103, 66);
            this.btnDeleteGame.TabIndex = 7;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(40, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "View Game History";
            // 
            // btnViewGameDetails
            // 
            this.btnViewGameDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewGameDetails.BackgroundImage")));
            this.btnViewGameDetails.FlatAppearance.BorderSize = 0;
            this.btnViewGameDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGameDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGameDetails.ForeColor = System.Drawing.Color.LightGreen;
            this.btnViewGameDetails.Location = new System.Drawing.Point(43, 224);
            this.btnViewGameDetails.Name = "btnViewGameDetails";
            this.btnViewGameDetails.Size = new System.Drawing.Size(100, 66);
            this.btnViewGameDetails.TabIndex = 6;
            this.btnViewGameDetails.Text = "View Game";
            this.btnViewGameDetails.UseVisualStyleBackColor = true;
            this.btnViewGameDetails.Click += new System.EventHandler(this.btnViewGameDetails_Click);
            // 
            // cblGameHistory
            // 
            this.cblGameHistory.CheckOnClick = true;
            this.cblGameHistory.FormattingEnabled = true;
            this.cblGameHistory.Location = new System.Drawing.Point(43, 47);
            this.cblGameHistory.Name = "cblGameHistory";
            this.cblGameHistory.Size = new System.Drawing.Size(400, 154);
            this.cblGameHistory.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(524, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recent Games Played";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabApprove.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabGame.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabApprove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoRegUsers;
        private System.Windows.Forms.Button btnConfirmReject;
        private System.Windows.Forms.Button btnConfirmApproved;
        private System.Windows.Forms.CheckedListBox cblRegRequests;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.CheckedListBox cblUserDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewGameDetails;
        private System.Windows.Forms.CheckedListBox cblGameHistory;
    }
}