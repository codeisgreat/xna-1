using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Class_Library;
using System.Windows.Forms;

namespace Entry_GUI.GUI.PR
{
    public partial class frmPRViewUser : Form
    {
        public string SelectedImageURL = "";

        public frmPRViewUser()
        {
            InitializeComponent();
        }

        public frmPRViewUser(User myUser)
        {
            InitializeComponent();
            txtEmail.Text = "";
            txtImage.Text = myUser.ImageURL;
            txtEmail.Text = myUser.Email;
            txtPassword.Text = myUser.Password;
            txtPassword.PasswordChar = '*';
            txtPassword_2.Text = myUser.Password;
            txtPassword_2.PasswordChar ='*';
            txtUsername.Text = myUser.UserName;
            txtUsername.Enabled= false;
            pictureBox1.ImageLocation = myUser.ImageURL;
            txtGamesWon.Text = myUser.TotalWins.ToString();
            txtTotalGames.Text= myUser.TotalGames.ToString();
            txtSkill.Text = myUser.GetSkill().ToString();
            Refresh();
            SelectedImageURL = myUser.ImageURL;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap myImage = new Bitmap(open.FileName);
                    SelectedImageURL = Helper.ResizeImage(open.FileName, 200, 200, false);

                    pictureBox1.Image = new Bitmap(SelectedImageURL);
                    txtImage.Text = SelectedImageURL;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!txtPassword_2.Text.ToString().Equals(txtPassword.Text.ToString()))
            {
                MessageBox.Show("Error: Passwords dont match");
                return;
            }

            try
            {
                User myUser = new User();
                myUser.Email = txtEmail.Text;
                myUser.ImageURL = SelectedImageURL;
                myUser.Password = txtPassword.Text;
                myUser.IsApproved = true;
                myUser.UserName = txtUsername.Text;
                myUser.ImageURL = txtImage.Text;

                UserList myUserList = new UserList();
                XMLHelper<UserList> myXML = new XMLHelper<UserList>();
                myXML.Load(ref myUserList);
                int Index = myUserList.FindName(myUser.UserName);
                if (Index != -1)
                {
                    myUserList.RemoveItem(Index);
                    myUserList.AddItem(myUser);
                    myXML.Save(myUserList);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error: This username does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message.ToString());
                return;
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtImage.Text = "";
            txtEmail.Text = "";
            this.Dispose();
        }

        private void frmPRViewUser_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPRViewUser_Resize(object sender, EventArgs e)
        {
            this.Height = 625;
            this.Width = 816;
        }
    }
}
