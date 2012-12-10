using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Library
{
    public class ActiveUserList
    {
        [XmlElement("myActiveList")]
        private ArrayList myActiveUserList;

        public ActiveUserList()
        {
            myActiveUserList = new ArrayList();
        }

        public User[] myActiveUsers
        {
            get
            {
                User[] myUsers = new User[myActiveUserList.Count];
                myActiveUserList.CopyTo(myUsers);
                return myUsers;
            }
            set
            {
                if (value == null)
                    return;
                User[] myUsers = (User[])value;
                myActiveUserList.Clear();
                foreach (User myUser in myUsers)
                    myActiveUserList.Add(myUser);
            }
        }

        public Boolean RemoveItem(int UserIndex)
        {
            try
            {
                myActiveUserList.RemoveAt(UserIndex);
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
                myActiveUserList.Add(myUser);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
