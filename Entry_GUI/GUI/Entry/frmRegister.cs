using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class_Library;

namespace Main_XNA_Game
{
    public partial class frmRegister : Form
    {
        public delegate void WriteInMain();
        public event WriteInMain WriteInHome;
        public String SelectedImageURL = "";
        public Image[,] myImages;
        public String[] myURLs;

        public frmRegister()
        {
            InitializeComponent();
            myImages = new Image[9,2];
            myImages = Helper.GetRecentImages();

            myURLs = new String[9];
            myURLs = Helper.GetRecentImagesURLs();

            pb1.Image = myImages[0,0];
            pb2.Image = myImages[1,0];
            pb3.Image = myImages[2,0];
            pb4.Image = myImages[3,0];
            pb5.Image = myImages[4,0];
            pb6.Image = myImages[5,0];
            pb7.Image = myImages[6,0];
            pb8.Image = myImages[7,0];
            pb9.Image = myImages[8,0];
            Refresh();
        }



        private void btnRegister_Click(object sender, EventArgs e)
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
                myUser.CostPerGame = 1.0;
                myUser.Balance = 50;
                myUser.Password = txtPassword.Text;
                myUser.UserName = txtUsername.Text;
                myUser.ImageURL = Helper.GetImageDirectory() + "\\" +  txtImage.Text;

                UserList myUserList = new UserList();
                XMLHelper<UserList> myXML = new XMLHelper<UserList>();
                myXML.Load(ref myUserList);
                if(myUserList.FindName(myUser.UserName) == -1)
                {
                    myUserList.AddItem(myUser);
                    myXML.Save(myUserList);
                    this.Dispose();
                    if (WriteInHome != null)
                        WriteInHome();                    
                }
                else
                {
                    MessageBox.Show("This Username has been Taken, Please Select Another Name");
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
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtPassword_2.Text = "";
            txtUsername.Text = "";
            this.Dispose();

            

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
                    SelectedImageURL = Helper.ResizeImage(open.FileName,  200, 200, false);

                    pictureBox1.Image = new Bitmap(SelectedImageURL);
                    txtImage.Text = SelectedImageURL;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[0, 1];
            txtImage.Text = myURLs[0];
            
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[1, 1];
            txtImage.Text = myURLs[1];
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[2, 1];
            txtImage.Text = myURLs[2];
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[3, 1];
            txtImage.Text = myURLs[3];
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[4, 1];
            txtImage.Text = myURLs[4];
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[5, 1];
            txtImage.Text = myURLs[5];
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[6, 1];
            txtImage.Text = myURLs[6];
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[7, 1];
            txtImage.Text = myURLs[7];
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myImages[8, 1];
            txtImage.Text = myURLs[8];
        }

        private void frmRegister_Resize(object sender, EventArgs e)
        {
            this.Height = 625;
            this.Width = 816;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            
        }



    }
}
