using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Pong_Component;
using Class_Library;

namespace Main_XNA_Game
{
    public partial class FrmMain : Form
    {        

        #region Open PR Register
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister myRegister = new frmRegister();
            myRegister.WriteInHome += new frmRegister.WriteInMain(myRegister_WriteInHome);
            this.Visible = false;
            myRegister.Show();
        }

        void myRegister_WriteInHome()
        {
            this.Visible = true;
        }
        #endregion

        #region Open PR SA Login

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin myLogin = new frmLogin();
            myLogin.LoginSuccessful += new frmLogin.LoginEnded(myLogin_LoginSuccessful);
            myLogin.SALogin += new frmLogin.LoginSA(myLogin_SALogin);
            myLogin.Show();
        }

        void myLogin_SALogin()
        {
            Main_XNA_Game.GUI.SA.frmHome mySAHome = new Main_XNA_Game.GUI.SA.frmHome();
            mySAHome.mySALogout += new Main_XNA_Game.GUI.SA.frmHome.SALogout(mySAHome_mySALogout);
            this.Visible = false;
            mySAHome.Visible = true;

        }

        void mySAHome_mySALogout()
        {
            this.Visible = true;
        }

        void myLogin_LoginSuccessful(Class_Library.User usr)
        {
            Main_XNA_Game.GUI.PR.frmHome myPRHome = new Main_XNA_Game.GUI.PR.frmHome(usr);
            myPRHome.myPRLogout += new Main_XNA_Game.GUI.PR.frmHome.PRLogout(myPRHome_myPRLogout);
            this.Visible = false;
            myPRHome.Show();
        }

        void myPRHome_myPRLogout()
        {
            this.Visible = true;
        }
        #endregion
        
        #region Init Game

        public FrmMain()
        {
            InitializeComponent();
            if(!System.IO.Directory.Exists(Helper.GetDataDirectory()))
            {
                System.IO.Directory.CreateDirectory(Helper.GetDataDirectory());
            }
            if (!System.IO.Directory.Exists(Helper.GetImageDirectory()))
            {
                System.IO.Directory.CreateDirectory(Helper.GetImageDirectory());
            }

        }

        public void Add(String cmd)
        {
            //listBox1.Items.Add(cmd);
        }
        public void InitQuickPlay()
        {
            if (this.InvokeRequired)
            {                
                this.Invoke(new MethodInvoker(delegate { this.Visible = false; }));
                Pong_Component.Program myProgram = new Pong_Component.Program();
                myProgram.PlayMusicTitle();
                myProgram.GameEnded += new Pong_Component.Program.GameEndedHandler(myProgram_GameEnded);
                myProgram.Init();
            }            
        }

        void myProgram_GameEnded(Object obj)
        {
            //String Msg = "At this point ControlPasses back to the main Form, along with an object which represents the updated list of the two players that were playing the game";

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { this.Visible = true; }));             
            }      
        }

        private void buttonQuickPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Library.Helper.SetQuickPlayOption(true);
            Thread t = new Thread(delegate() { InitQuickPlay(); });
            t.Priority = ThreadPriority.Highest;
            t.Start();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLogin.Visible = true;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLogin.Visible = false;
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRegister.Visible = true;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRegister.Visible = false;
        }

        private void buttonQuickPlay_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxQuickPlay.Visible = true;
        }

        private void buttonQuickPlay_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxQuickPlay.Visible = false;
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExit.Visible = true;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
         
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            this.Height = 625;
            this.Width = 816;
        }

          
    }
}
