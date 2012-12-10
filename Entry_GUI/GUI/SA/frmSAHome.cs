using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Class_Library;
using Entry_GUI.GUI.PR;

namespace Main_XNA_Game.GUI.SA
{
    public enum Options
    {
        Approve,
        Reject,
        Delete,
        View
    }

    public partial class frmHome : Form
    {
        public delegate void SALogout();
        public event SALogout mySALogout;

        UserList myUserList = new UserList();
        XMLHelper<UserList> myUserXML = new XMLHelper<UserList>();

        GameHistory myGameHistory = new GameHistory();
        XMLHelper<GameHistory> myGameHistoryXML = new XMLHelper<GameHistory>();

        public frmHome()
        {
            InitializeComponent();
            lblNoRegUsers.Visible = true;
            RefreshListOfApprovedUsers();
            RefreshListOfGames();
        }

        public void RefreshListOfGames()
        {
            cblGameHistory.Items.Clear();
            myGameHistoryXML.Load(ref myGameHistory);
            Game Temp;
            for (int i = 0; i < myGameHistory.myGames.Length; i++)
            {
                Temp = myGameHistory.myGames[i];
                if(Temp.IsVisible)
                    cblGameHistory.Items.Add(Temp.ToString(), false);                
            }
        }

        public void RefreshListOfApprovedUsers()
        {
            cblRegRequests.Items.Clear();
            cblUserDetails.Items.Clear();
            myUserXML.Load(ref myUserList);
            User Temp;
            int count = 0;
            for (int i = 0; i < myUserList.myUsers.Length; i++)
            {
                Temp = myUserList.myUsers[i];
                if (!Temp.IsApproved)
                {
                    cblRegRequests.Items.Add(Temp.GetName() + ", Credit = " + Temp.Balance.ToString(), false);
                    count++;
                }
                else
                {
                    cblUserDetails.Items.Add(Temp.GetName(), false);
                }
            }

            if (count == 0)
            {
                lblNoRegUsers.Visible = true;
                cblRegRequests.Enabled = false;
                //tabControl1.SelectedIndex = 1;
            }
            else
            {
                lblNoRegUsers.Visible = false;
                cblRegRequests.Enabled = true;
            }
        }

        public void ViewUserDetails(int UserIndex)
        {
            myUserXML.Load(ref myUserList);
            User Temp = myUserList.myUsers[UserIndex];
            frmPRViewUser myForm = new frmPRViewUser(Temp);
            myForm.Show();            
        }
        

        
        public Boolean UpdateSelectedUsers(Options myOption)
        {
            myUserXML.Load(ref myUserList);
            bool NoneSelected = true;
            String TempName;
            Boolean BalanceRequest = false;
            int TempIndex;

            if (myOption == Options.Delete)
            {
                for (int i = 0; i < cblUserDetails.Items.Count; i++)
                {
                    if (cblUserDetails.GetItemChecked(i))
                    {
                        TempName = cblUserDetails.Items[i].ToString();
                        TempIndex = myUserList.FindName(TempName);
                        myUserList.RemoveItem(TempIndex);
                    }
                }
            }
            else
            {
                for (int i = 0; i < cblRegRequests.Items.Count; i++)
                {
                    if (cblRegRequests.GetItemChecked(i))
                    {
                        String Temp = cblRegRequests.Items[i].ToString();
                        String[] TempArray = Temp.Split(',');
                        if (TempArray.Length < 1)
                        {
                            TempName = Temp;
                        }
                        else
                        {
                            TempName = TempArray[0];
                            BalanceRequest = true;
                        }
                        switch (myOption)
                        {
                            case Options.Approve:                             
                                TempIndex = myUserList.FindName(TempName);
                                myUserList.myUsers[TempIndex].IsApproved = true;
                                NoneSelected = false;
                                if(BalanceRequest)
                                    MessageBox.Show("Balance Increase Approved");
                                else
                                    MessageBox.Show("Selected User's Confirmed. They can now Login into the System");
                                break;
                            case Options.Reject:
                                TempIndex = myUserList.FindName(TempName);
                                myUserList.RemoveItem(TempIndex);
                                MessageBox.Show("Selected User's Removed From the System. They can no longer Login into the System");
                                break;
                            default:
                                String temp;
                                break;
                        }

                    }
                }
            }
            myUserXML.Save(myUserList);
            RefreshListOfApprovedUsers();
         
         return NoneSelected;
          
        }


        #region Click_Events
        private void btnConfirmReject_Click_1(object sender, EventArgs e)
        {
            if (!UpdateSelectedUsers(Options.Reject))
            {               
                RefreshListOfApprovedUsers();
            }
        }


        private void btnConfirmApproved_Click_1(object sender, EventArgs e)
        {
            if (!UpdateSelectedUsers(Options.Approve))
            {                
                RefreshListOfApprovedUsers();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!UpdateSelectedUsers(Options.Delete))
            {                
                RefreshListOfApprovedUsers();
            }
        }
        #endregion

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            String TempName;
            int TempIndex;
            if (cblUserDetails.CheckedItems.Count > 1)
            {
                MessageBox.Show("You can only View One User at a Time");
                return;
            }
            else
            {
                for (int i = 0; i < cblUserDetails.Items.Count; i++)
                {
                    if (cblUserDetails.GetItemChecked(i))
                    {
                        TempName = cblUserDetails.Items[i].ToString();
                        TempIndex = myUserList.FindName(TempName);
                        ViewUserDetails(TempIndex);
                        return;
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (mySALogout != null)
            {
                this.Dispose();
                mySALogout();
            }
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mySALogout != null)
            {
                this.Dispose();
                mySALogout();
            }
        }


        public void ViewGameDetails(int Index)
        {
            MessageBox.Show(myGameHistory.myGames[Index].ToString());
        }

        private void btnViewGameDetails_Click(object sender, EventArgs e)
        {
            String GameID;
            int TempIndex;
            if (cblGameHistory.CheckedItems.Count > 1)
            {
                MessageBox.Show("You can only View One Game at a Time");
                return;
            }
            else
            {
                for (int i = 0; i < cblGameHistory.Items.Count; i++)
                {
                    if (cblGameHistory.GetItemChecked(i))
                    {
                        ViewGameDetails(i);
                        return;
                    }
                }
            }
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {            
            myGameHistoryXML.Load(ref myGameHistory);
            for (int i = 0; i < cblGameHistory.Items.Count; i++)
            {                
                if (cblGameHistory.GetItemChecked(i))
                {
                    myGameHistory.myGames[i].IsVisible = false;
                }
            }
            myGameHistoryXML.Save(myGameHistory);
            RefreshListOfGames();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
