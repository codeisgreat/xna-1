namespace Main_XNA_Game
{
    partial class FrmMain
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonQuickPlay = new System.Windows.Forms.Button();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegister = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuickPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuickPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(50, 193);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 70);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(183, 276);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(131, 70);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseEnter += new System.EventHandler(this.btnRegister_MouseEnter);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(577, 193);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 62);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            // 
            // buttonQuickPlay
            // 
            this.buttonQuickPlay.FlatAppearance.BorderSize = 0;
            this.buttonQuickPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonQuickPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonQuickPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuickPlay.Location = new System.Drawing.Point(373, 276);
            this.buttonQuickPlay.Name = "buttonQuickPlay";
            this.buttonQuickPlay.Size = new System.Drawing.Size(160, 69);
            this.buttonQuickPlay.TabIndex = 5;
            this.buttonQuickPlay.UseVisualStyleBackColor = true;
            this.buttonQuickPlay.MouseLeave += new System.EventHandler(this.buttonQuickPlay_MouseLeave);
            this.buttonQuickPlay.Click += new System.EventHandler(this.buttonQuickPlay_Click);
            this.buttonQuickPlay.MouseEnter += new System.EventHandler(this.buttonQuickPlay_MouseEnter);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Enabled = false;
            this.pictureBoxLogin.Image = global::Entry_GUI.Properties.Resources.btnlogin;
            this.pictureBoxLogin.Location = new System.Drawing.Point(18, 194);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(160, 70);
            this.pictureBoxLogin.TabIndex = 6;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Visible = false;
            // 
            // pictureBoxRegister
            // 
            this.pictureBoxRegister.Enabled = false;
            this.pictureBoxRegister.Image = global::Entry_GUI.Properties.Resources.btnregister;
            this.pictureBoxRegister.Location = new System.Drawing.Point(163, 276);
            this.pictureBoxRegister.Name = "pictureBoxRegister";
            this.pictureBoxRegister.Size = new System.Drawing.Size(160, 70);
            this.pictureBoxRegister.TabIndex = 7;
            this.pictureBoxRegister.TabStop = false;
            this.pictureBoxRegister.Visible = false;
            // 
            // pictureBoxQuickPlay
            // 
            this.pictureBoxQuickPlay.Enabled = false;
            this.pictureBoxQuickPlay.Image = global::Entry_GUI.Properties.Resources.btnquickplay;
            this.pictureBoxQuickPlay.Location = new System.Drawing.Point(373, 275);
            this.pictureBoxQuickPlay.Name = "pictureBoxQuickPlay";
            this.pictureBoxQuickPlay.Size = new System.Drawing.Size(160, 70);
            this.pictureBoxQuickPlay.TabIndex = 8;
            this.pictureBoxQuickPlay.TabStop = false;
            this.pictureBoxQuickPlay.Visible = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Enabled = false;
            this.pictureBoxExit.Image = global::Entry_GUI.Properties.Resources.btnexit;
            this.pictureBoxExit.Location = new System.Drawing.Point(549, 182);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(160, 70);
            this.pictureBoxExit.TabIndex = 9;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Entry_GUI.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(252, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 114);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Controls.Add(this.pictureBoxQuickPlay);
            this.panel1.Controls.Add(this.pictureBoxRegister);
            this.panel1.Controls.Add(this.pictureBoxLogin);
            this.panel1.Controls.Add(this.buttonQuickPlay);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(50, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 349);
            this.panel1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Entry_GUI.Properties.Resources.mainback3;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Pong";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuickPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonQuickPlay;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxRegister;
        private System.Windows.Forms.PictureBox pictureBoxQuickPlay;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;

    }
}

