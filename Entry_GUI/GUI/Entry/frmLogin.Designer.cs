namespace Main_XNA_Game
{
    partial class frmLogin
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
            this.txtFirstUser = new System.Windows.Forms.TextBox();
            this.txtFirstPassword = new System.Windows.Forms.TextBox();
            this.pnlFirst = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlFirst.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstUser
            // 
            this.txtFirstUser.Location = new System.Drawing.Point(115, 52);
            this.txtFirstUser.Name = "txtFirstUser";
            this.txtFirstUser.Size = new System.Drawing.Size(123, 20);
            this.txtFirstUser.TabIndex = 1;
            // 
            // txtFirstPassword
            // 
            this.txtFirstPassword.Location = new System.Drawing.Point(115, 101);
            this.txtFirstPassword.Name = "txtFirstPassword";
            this.txtFirstPassword.PasswordChar = '*';
            this.txtFirstPassword.Size = new System.Drawing.Size(123, 20);
            this.txtFirstPassword.TabIndex = 2;
            // 
            // pnlFirst
            // 
            this.pnlFirst.Controls.Add(this.lblMain);
            this.pnlFirst.Controls.Add(this.btnRegister);
            this.pnlFirst.Controls.Add(this.lblPassword);
            this.pnlFirst.Controls.Add(this.lblUserName);
            this.pnlFirst.Controls.Add(this.txtFirstUser);
            this.pnlFirst.Controls.Add(this.txtFirstPassword);
            this.pnlFirst.Controls.Add(this.btnLogin);
            this.pnlFirst.Location = new System.Drawing.Point(42, 30);
            this.pnlFirst.Name = "pnlFirst";
            this.pnlFirst.Size = new System.Drawing.Size(259, 220);
            this.pnlFirst.TabIndex = 3;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMain.Location = new System.Drawing.Point(83, 10);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(71, 25);
            this.lblMain.TabIndex = 5;
            this.lblMain.Text = "Login ";
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = global::Entry_GUI.Properties.Resources.buttonback;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnRegister.Location = new System.Drawing.Point(138, 152);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 66);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Cancel";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.LightGreen;
            this.lblPassword.Location = new System.Drawing.Point(16, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 18);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.LightGreen;
            this.lblUserName.Location = new System.Drawing.Point(14, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 18);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::Entry_GUI.Properties.Resources.buttonback;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnLogin.Location = new System.Drawing.Point(19, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 66);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(351, 283);
            this.Controls.Add(this.pnlFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Player";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Resize += new System.EventHandler(this.frmLogin_Resize);
            this.pnlFirst.ResumeLayout(false);
            this.pnlFirst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtFirstUser;
        private System.Windows.Forms.TextBox txtFirstPassword;
        private System.Windows.Forms.Panel pnlFirst;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnRegister;
    }
}