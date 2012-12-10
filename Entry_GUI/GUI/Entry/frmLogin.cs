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
    public partial class frmLogin : Form
    {
        public delegate void LoginEnded(User usr);
        public event LoginEnded LoginSuccessful;

        public delegate void LoginSA();
        public event LoginSA SALogin;

        UserList myUserList = new UserList();
        XMLHelper<UserList> myUserXML = new XMLHelper<UserList>();   
        User UserOne;

        GUI.PR.frmHome myPRHome = null;
        GUI.SA.frmHome mySAHome = null;

        public frmLogin()
        {
            InitializeComponent();            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String Username = txtFirstUser.Text;
            String Password = txtFirstPassword.Text;
            if (Username.ToUpper().Equals("SA") && Password.ToUpper().Equals("SA"))
            {
                if (SALogin != null)
                {
                    this.Dispose();
                    SALogin();
                }

            }
            else
            {
                //Verify Username and Password from UserList
                myUserXML.Load(ref myUserList);
                Boolean UserFound = false;
                
                for (int i = 0; i < myUserList.myUsers.Length; i++)
                {
                    if (myUserList.myUsers[i].UserName.ToUpper().Equals(Username.ToUpper()) && myUserList.myUsers[i].Password.ToUpper().Equals(Password.ToUpper()))
                    {
                        if (myUserList.myUsers[i].IsApproved == false)
                        {
                            MessageBox.Show("User has not been approved by SA yet");
                                return;
                        }
                        if (LoginSuccessful != null)
                        {
                            UserFound = true;
                            UserOne = myUserList.myUsers[i];

                            myPRHome = new Main_XNA_Game.GUI.PR.frmHome(UserOne);
                            GamePlayers myGamePlayers = new GamePlayers();
                            XMLHelper<GamePlayers> myXMLGame = new XMLHelper<GamePlayers>();
                            myGamePlayers.AddItem(UserOne);
                            myXMLGame.Save(myGamePlayers);
                            //myPRHome.Visible = true;
                            this.Dispose();
                            LoginSuccessful(UserOne);
                            break;                                              
                        }
                        break;
  
                    }
                }
                if (!UserFound)
                    MessageBox.Show("Login Unsuccessful");
                
                    

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {

        }
    }
}
