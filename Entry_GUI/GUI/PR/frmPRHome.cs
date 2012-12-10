using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class_Library;

using System.Threading;

namespace Main_XNA_Game.GUI.PR
{
    public partial class frmHome : Form
    {
        public delegate void PRLogout();
        public event PRLogout myPRLogout;

        ///Code Jay would do
        XMLHelper<UserList> myUserXML = new XMLHelper<UserList>();
        UserList myUserList = new UserList();
        GamePlayers myPlayers = new GamePlayers();
        User CurrentUser;

        #region NewCode
        SaveGameList mySavedGames = new SaveGameList();
        XMLHelper<SaveGameList> mySavedGamesXML = new XMLHelper<SaveGameList>();

        public void RefreshSavedGames(User myUser)
        {
            mySavedGamesXML.Load(ref mySavedGames);
            lblSavedGames.Visible = false;
            if (mySavedGames.myGames.Length == 0)
            {
                lblSavedGames.Visible = true;
                lblSavedGames.Text = "No Games Loaded for Current User";
            }
            else
            {
                for (int i = 0; i < mySavedGames.myGames.Length; i++)
                {
                    SaveGame Current = mySavedGames.myGames[i];
                    if (Current.Player1_Name.ToUpper().Equals(myUser.UserName.ToUpper()) || Current.Player2_Name.ToUpper().Equals(myUser.UserName.ToUpper()))
                    {
                        cbSavedGames.Items.Add(Current.ToString());
                    }
                }
            }
        }

        #endregion

        public frmHome(User myUserOne)
        {            
            InitializeComponent();
            CurrentUser = myUserOne;
            RefreshSavedGames(CurrentUser);
            txtUser1.Text = myUserOne.UserName;
            myPlayers.AddItem(myUserOne);
            if (myUserOne.Balance <= 0)
            {
                lblLowBalance.Visible = true;
                lblLowBalance.Text = "Warning: Balance depleted, You will not be able to play Multiplayer Games";
            }
            else if(myUserOne.Balance/myUserOne.CostPerGame <= 3)
            {
                lblLowBalance.Visible = true;
                lblLowBalance.Text = "Warning: Balance is Low, At your current Cost Per Game, You can Play only 3 more Games";
            }
            else
            {
                lblLowBalance.Text = "";
                lblLowBalance.Visible = false;
            }
        }

        public void Init()
        {
            if (this.InvokeRequired)
            {
                Class_Library.Helper.SetQuickPlayOption(false);
                this.Invoke(new MethodInvoker(delegate { this.Visible = false; }));
                Pong_Component.Program myProgram = new Pong_Component.Program();
                myProgram.PlayMusicTitle();
                myProgram.GameEnded += new Pong_Component.Program.GameEndedHandler(myProgram_GameEnded);
                myProgram.Init();
            }      
        }

        void myProgram_GameEnded(Object obj)
        {
            if (this.InvokeRequired)
            {
                 this.Invoke(new MethodInvoker(delegate { this.Visible = true; }));
                 txtPass2.Invoke(new MethodInvoker(delegate { txtPass2.Text = ""; }));
                 String Msg = "At this point ControlPasses back to the main Form, along with an object which represents the updated list of the two players that were playing the game";
                 MessageBox.Show(Msg);
                 GamePlayers myGame = new GamePlayers();
                 UserList myUserList = new UserList();
                 XMLHelper<GamePlayers> myXMLGame = new XMLHelper<GamePlayers>();
                 XMLHelper<UserList> myXMLUser = new XMLHelper<UserList>();

                 myXMLGame.Load(ref myGame);
                 myXMLUser.Load(ref myUserList);

                 if (myGame.myPlayers.Length > 0)
                 {
                     int one = myUserList.FindName(myGame.myPlayers[0].UserName);
                     int two = myUserList.FindName(myGame.myPlayers[1].UserName);
                     myUserList.myUsers[one].TotalWins = myUserList.myUsers[one].TotalWins + myGame.myPlayers[0].TotalWins;
                     myUserList.myUsers[one].TotalGames = myUserList.myUsers[one].TotalGames + myGame.myPlayers[0].TotalGames;

                     myUserList.myUsers[two].TotalWins = myUserList.myUsers[two].TotalWins + myGame.myPlayers[1].TotalWins;
                     myUserList.myUsers[two].TotalGames = myUserList.myUsers[two].TotalGames + myGame.myPlayers[1].TotalGames;

                     myXMLUser.Save(myUserList);

                 }
            }

            
        }

        public void Begin()
        {          
            Thread t = new Thread(delegate() { Init(); });
            t.Priority = ThreadPriority.Highest;
            t.Start();      
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            String Username = txtUser2.Text;
            String Password = txtPass2.Text;

            if (Username.ToUpper().Equals(txtUser1.Text.ToString().ToUpper()))
            {
                MessageBox.Show("User cannot play against Himself");
                return;
            }

            if (Username.ToUpper().Equals("SA") )
            {
                MessageBox.Show("SA Cannot play against another Player");
                return;
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
                        myPlayers.AddItem(myUserList.myUsers[i]);
                        XMLHelper<GamePlayers> myPlayersXML = new XMLHelper<GamePlayers>();
                        myPlayersXML.Save(myPlayers);                        
                        Begin();
                        UserFound = true;                                                
                        break;
                    }
                }
                if (!UserFound)
                    MessageBox.Show("Login Unsuccessful, Try Again. (Passwords are case sensitive)");                

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (myPRLogout != null)
            {
                this.Dispose();
                myPRLogout();
            }
            
        }

        private void btnLogout_Click(object sender, FormClosedEventArgs e)
        {
            if (myPRLogout != null)
            {
                this.Dispose();
                myPRLogout();
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCheck.Visible = false;
            txtCheckNo.Visible = false;
            String temp = comboBox1.SelectedText;
            switch (temp)
            {
                case "Paypal":
                    break;
                case "Check":
                    lblCheck.Visible = true;
                    txtCheckNo.Visible = true;
                    break;
                case "Trial":
                    txtCredit.Text = "5";
                    txtCredit.Enabled = false;
                    break;
                default:
                    break;

            }
        }

        private void btnRequestCredit_Click(object sender, EventArgs e)
        {
            if (txtCredit.Text.Equals(""))
                txtCredit.Text = "0";
            CurrentUser.Balance = Convert.ToInt32(txtCredit.Text);
            myUserXML.Load(ref myUserList);
            int index = myUserList.FindName(CurrentUser.UserName);
            myUserList.myUsers[index].Balance = CurrentUser.Balance;
            myUserList.myUsers[index].IsApproved = false;
            myUserXML.Save(myUserList);
            MessageBox.Show("Request Sent, You must now Logout of the System");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Height = 625;
            this.Width = 816;
            
            
        }
                
    }
}
