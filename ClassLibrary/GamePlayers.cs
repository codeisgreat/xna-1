using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Library
{
    // Shopping list class which will be serialized
    [XmlRoot("GamePlayers")]
    public class GamePlayers
    {
        [XmlElement("myGamePlayers")]
        private ArrayList myGamePlayers;

        public GamePlayers()
        {
            myGamePlayers = new ArrayList();
        }

        public int FindName(String name)
        {
            for (int i = 0; i < myGamePlayers.Count; i++)
            {
                if (myPlayers[i].GetName().ToUpper().Equals(name.ToUpper()))
                    return i;
            }
            return -1;
        }

        public User[] myPlayers
        {
            get
            {
                User[] myPlayers = new User[myGamePlayers.Count];
                myGamePlayers.CopyTo(myPlayers);
                return myPlayers;
            }
            set
            {
                if (value == null)
                    return;
                User[] myPlayers = (User[])value;
                myGamePlayers.Clear();
                foreach (User myPlayer in myPlayers)
                    myGamePlayers.Add(myPlayer);
            }
        }

        public Boolean AddItem(User myPlayer)
        {
            try
            {
                myGamePlayers.Add(myPlayer);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void RemoveItem(int PlayerIndex)
        {
            myGamePlayers.RemoveAt(PlayerIndex);
        }

    }



}