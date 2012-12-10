namespace Main_XNA_Game.GUI.PR
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbRecentGames = new System.Windows.Forms.TabPage();
            this.lblLowBalance = new System.Windows.Forms.Label();
            this.lblNoRegUsers = new System.Windows.Forms.Label();
            this.BtnDeleteGame = new System.Windows.Forms.Button();
            this.btnViewGame = new System.Windows.Forms.Button();
            this.cblRegRequests = new System.Windows.Forms.CheckedListBox();
            this.tbMultiplayer = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLoadGame = new System.Windows.Forms.TabPage();
            this.tbCredit = new System.Windows.Forms.TabPage();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRequestCredit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSavedGames = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbSavedGames = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbRecentGames.SuspendLayout();
            this.tbMultiplayer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbLoadGame.SuspendLayout();
            this.tbCredit.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "PR administration Panel";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(629, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 587);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbRecentGames);
            this.tabControl1.Controls.Add(this.tbMultiplayer);
            this.tabControl1.Controls.Add(this.tbLoadGame);
            this.tabControl1.Controls.Add(this.tbCredit);
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 397);
            this.tabControl1.TabIndex = 12;
            // 
            // tbRecentGames
            // 
            this.tbRecentGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbRecentGames.Controls.Add(this.lblLowBalance);
            this.tbRecentGames.Controls.Add(this.lblNoRegUsers);
            this.tbRecentGames.Controls.Add(this.BtnDeleteGame);
            this.tbRecentGames.Controls.Add(this.btnViewGame);
            this.tbRecentGames.Controls.Add(this.cblRegRequests);
            this.tbRecentGames.Location = new System.Drawing.Point(4, 22);
            this.tbRecentGames.Name = "tbRecentGames";
            this.tbRecentGames.Padding = new System.Windows.Forms.Padding(3);
            this.tbRecentGames.Size = new System.Drawing.Size(687, 371);
            this.tbRecentGames.TabIndex = 0;
            this.tbRecentGames.Text = "Recent Games";
            this.tbRecentGames.UseVisualStyleBackColor = true;
            // 
            // lblLowBalance
            // 
            this.lblLowBalance.AutoSize = true;
            this.lblLowBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowBalance.ForeColor = System.Drawing.Color.Red;
            this.lblLowBalance.Location = new System.Drawing.Point(36, 16);
            this.lblLowBalance.Name = "lblLowBalance";
            this.lblLowBalance.Size = new System.Drawing.Size(59, 20);
            this.lblLowBalance.TabIndex = 12;
            this.lblLowBalance.Text = "lblError";
            // 
            // lblNoRegUsers
            // 
            this.lblNoRegUsers.AutoSize = true;
            this.lblNoRegUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRegUsers.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNoRegUsers.Location = new System.Drawing.Point(248, 62);
            this.lblNoRegUsers.Name = "lblNoRegUsers";
            this.lblNoRegUsers.Size = new System.Drawing.Size(152, 18);
            this.lblNoRegUsers.TabIndex = 10;
            this.lblNoRegUsers.Text = "List of Recent Games";
            // 
            // BtnDeleteGame
            // 
            this.BtnDeleteGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteGame.BackgroundImage")));
            this.BtnDeleteGame.FlatAppearance.BorderSize = 0;
            this.BtnDeleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteGame.ForeColor = System.Drawing.Color.LightGreen;
            this.BtnDeleteGame.Location = new System.Drawing.Point(353, 272);
            this.BtnDeleteGame.Name = "BtnDeleteGame";
            this.BtnDeleteGame.Size = new System.Drawing.Size(103, 66);
            this.BtnDeleteGame.TabIndex = 11;
            this.BtnDeleteGame.Text = "Delete Game";
            this.BtnDeleteGame.UseVisualStyleBackColor = true;
            // 
            // btnViewGame
            // 
            this.btnViewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewGame.BackgroundImage")));
            this.btnViewGame.FlatAppearance.BorderSize = 0;
            this.btnViewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGame.ForeColor = System.Drawing.Color.LightGreen;
            this.btnViewGame.Location = new System.Drawing.Point(131, 272);
            this.btnViewGame.Name = "btnViewGame";
            this.btnViewGame.Size = new System.Drawing.Size(100, 66);
            this.btnViewGame.TabIndex = 9;
            this.btnViewGame.Text = "View Game";
            this.btnViewGame.UseVisualStyleBackColor = true;
            // 
            // cblRegRequests
            // 
            this.cblRegRequests.FormattingEnabled = true;
            this.cblRegRequests.Location = new System.Drawing.Point(131, 93);
            this.cblRegRequests.Name = "cblRegRequests";
            this.cblRegRequests.Size = new System.Drawing.Size(400, 154);
            this.cblRegRequests.TabIndex = 8;
            // 
            // tbMultiplayer
            // 
            this.tbMultiplayer.Controls.Add(this.label3);
            this.tbMultiplayer.Controls.Add(this.label2);
            this.tbMultiplayer.Controls.Add(this.panel2);
            this.tbMultiplayer.Controls.Add(this.panel3);
            this.tbMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMultiplayer.Location = new System.Drawing.Point(4, 22);
            this.tbMultiplayer.Name = "tbMultiplayer";
            this.tbMultiplayer.Padding = new System.Windows.Forms.Padding(3);
            this.tbMultiplayer.Size = new System.Drawing.Size(687, 371);
            this.tbMultiplayer.TabIndex = 1;
            this.tbMultiplayer.Text = "Play Multiplayer Game";
            this.tbMultiplayer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Player Two Login (Must be a Registered Player)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player One (Already Logged In)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPass2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtUser2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnLogin2);
            this.panel2.Location = new System.Drawing.Point(378, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 236);
            this.panel2.TabIndex = 1;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(124, 88);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(100, 26);
            this.txtPass2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(124, 46);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(100, 26);
            this.txtUser2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Username";
            // 
            // btnLogin2
            // 
            this.btnLogin2.Location = new System.Drawing.Point(77, 142);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(134, 29);
            this.btnLogin2.TabIndex = 5;
            this.btnLogin2.Text = "Login Second Player";
            this.btnLogin2.UseVisualStyleBackColor = true;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPass1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtUser1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(70, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 236);
            this.panel3.TabIndex = 0;
            // 
            // txtPass1
            // 
            this.txtPass1.Enabled = false;
            this.txtPass1.Location = new System.Drawing.Point(126, 84);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(100, 26);
            this.txtPass1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // txtUser1
            // 
            this.txtUser1.Enabled = false;
            this.txtUser1.Location = new System.Drawing.Point(126, 42);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(100, 26);
            this.txtUser1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(70, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbLoadGame
            // 
            this.tbLoadGame.Controls.Add(this.panel4);
            this.tbLoadGame.Location = new System.Drawing.Point(4, 22);
            this.tbLoadGame.Name = "tbLoadGame";
            this.tbLoadGame.Size = new System.Drawing.Size(687, 371);
            this.tbLoadGame.TabIndex = 2;
            this.tbLoadGame.Text = "Load Saved Game";
            this.tbLoadGame.UseVisualStyleBackColor = true;
            // 
            // tbCredit
            // 
            this.tbCredit.Controls.Add(this.lblCheck);
            this.tbCredit.Controls.Add(this.txtCheckNo);
            this.tbCredit.Controls.Add(this.comboBox1);
            this.tbCredit.Controls.Add(this.label11);
            this.tbCredit.Controls.Add(this.label10);
            this.tbCredit.Controls.Add(this.txtCredit);
            this.tbCredit.Controls.Add(this.label9);
            this.tbCredit.Controls.Add(this.btnRequestCredit);
            this.tbCredit.Location = new System.Drawing.Point(4, 22);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(687, 371);
            this.tbCredit.TabIndex = 3;
            this.tbCredit.Text = "Request Game Credit";
            this.tbCredit.UseVisualStyleBackColor = true;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(456, 119);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(55, 13);
            this.lblCheck.TabIndex = 8;
            this.lblCheck.Text = "Check No";
            this.lblCheck.Visible = false;
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(517, 116);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(99, 20);
            this.txtCheckNo.TabIndex = 7;
            this.txtCheckNo.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PayPal",
            "Check\t",
            "Trial"});
            this.comboBox1.Location = new System.Drawing.Point(253, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Method of Payment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Request Credit Increase";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(253, 76);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(173, 20);
            this.txtCredit.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Credit Amount";
            // 
            // btnRequestCredit
            // 
            this.btnRequestCredit.Location = new System.Drawing.Point(170, 156);
            this.btnRequestCredit.Name = "btnRequestCredit";
            this.btnRequestCredit.Size = new System.Drawing.Size(155, 23);
            this.btnRequestCredit.TabIndex = 0;
            this.btnRequestCredit.Text = "Request Credit Increase";
            this.btnRequestCredit.UseVisualStyleBackColor = true;
            this.btnRequestCredit.Click += new System.EventHandler(this.btnRequestCredit_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSavedGames);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.cbSavedGames);
            this.panel4.Location = new System.Drawing.Point(38, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(611, 301);
            this.panel4.TabIndex = 1;
            // 
            // lblSavedGames
            // 
            this.lblSavedGames.AutoSize = true;
            this.lblSavedGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedGames.Location = new System.Drawing.Point(98, 48);
            this.lblSavedGames.Name = "lblSavedGames";
            this.lblSavedGames.Size = new System.Drawing.Size(132, 16);
            this.lblSavedGames.TabIndex = 16;
            this.lblSavedGames.Text = "List of Saved Games";
            this.lblSavedGames.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "List of Saved Games";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete Selected Game";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Load Selected Game";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbSavedGames
            // 
            this.cbSavedGames.FormattingEnabled = true;
            this.cbSavedGames.Location = new System.Drawing.Point(101, 76);
            this.cbSavedGames.Name = "cbSavedGames";
            this.cbSavedGames.Size = new System.Drawing.Size(400, 154);
            this.cbSavedGames.TabIndex = 12;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.panel1);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.btnLogout_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbRecentGames.ResumeLayout(false);
            this.tbRecentGames.PerformLayout();
            this.tbMultiplayer.ResumeLayout(false);
            this.tbMultiplayer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbLoadGame.ResumeLayout(false);
            this.tbCredit.ResumeLayout(false);
            this.tbCredit.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbRecentGames;
        private System.Windows.Forms.Label lblNoRegUsers;
        private System.Windows.Forms.Button BtnDeleteGame;
        private System.Windows.Forms.Button btnViewGame;
        private System.Windows.Forms.CheckedListBox cblRegRequests;
        private System.Windows.Forms.TabPage tbMultiplayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUser2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogin2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tbLoadGame;
        private System.Windows.Forms.Label lblLowBalance;
        private System.Windows.Forms.TabPage tbCredit;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRequestCredit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSavedGames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox cbSavedGames;
    }
}