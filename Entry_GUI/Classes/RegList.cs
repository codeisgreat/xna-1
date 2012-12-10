using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Main_XNA_Game
{
    // Shopping list class which will be serialized
    [XmlRoot("UserList")]
    public class RegList
    {
        [XmlElement("myUsers")]
        private ArrayList myRegList;

        public RegList()
        {
            myRegList = new ArrayList();
        }


        public User[] myUsers
        {
            get
            {
                User[] myUsers = new User[myRegList.Count];
                myRegList.CopyTo(myUsers);
                return myUsers;
            }
            set
            {
                if (value == null)
                    return;
                User[] myUsers = (User[])value;
                myRegList.Clear();
                foreach (User myUser in myUsers)
                    myRegList.Add(myUser);
            }
        }

        public Boolean RemoveItem(int UserIndex)
        {
            try
            {
                myRegList.RemoveAt(UserIndex);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean AddItem(User myUser)
        {
            try
            {
                myRegList.Add(myUser);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }



}