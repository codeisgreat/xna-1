using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Library
{
    // Shopping list class which will be serialized
    [XmlRoot("GameHistory")]
    public class GameHistory
    {
        [XmlElement("myGameHistory")]
        private ArrayList myGameHistory;

        public GameHistory()
        {
            myGameHistory = new ArrayList();
        }

        public Game[] myGames
        {
            get
            {
                Game[] myGames = new Game[myGameHistory.Count];
                myGameHistory.CopyTo(myGames);
                return myGames;
            }
            set
            {
                if (value == null)
                    return;
                Game[] myGames = (Game[])value;
                myGameHistory.Clear();
                foreach (Game myGame in myGames)
                    myGameHistory.Add(myGame);
            }
        }

        public int GetLastID()
        {
            int MAX = -1;
            for (int i = 0; i < myGames.Length; i++)
            {
                if (myGames[i].GameID > MAX)
                {
                    MAX = myGames[i].GameID;
                }
            }
            return MAX;
        }

        public Boolean AddItem(Game myPlayer)
        {
            try
            {
                myGameHistory.Add(myPlayer);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void RemoveItem(int GameIndex)
        {
            myGameHistory.RemoveAt(GameIndex);
        }

    }



}