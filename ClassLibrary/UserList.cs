using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Library
{
    // Shopping list class which will be serialized
    [XmlRoot("UserList")]
    public class UserList
    {
        [XmlElement("myUsers")]
        private ArrayList myUserList;

        public UserList()
        {
            myUserList = new ArrayList();
        }

        public int FindName(String name)
        {
            for (int i = 0; i < myUserList.Count; i++)
            {
                if (myUsers[i].GetName().ToUpper().Equals(name.ToUpper()))
                    return i;
            }
            return -1;
        }

        public User[] myUsers
        {
            get
            {
                User[] myUsers = new User[myUserList.Count];
                myUserList.CopyTo(myUsers);
                return myUsers;
            }
            set
            {
                if (value == null) 
                    return;
                User[] myUsers = (User[])value;
                myUserList.Clear();
                foreach (User myUser in myUsers)
                    myUserList.Add(myUser);
            }
        }

        public Boolean AddItem(User myUser)
        {
            try
            {
                myUserList.Add(myUser);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void RemoveItem(int UserIndex)
        {
            myUserList.RemoveAt(UserIndex);
        }

    }



}