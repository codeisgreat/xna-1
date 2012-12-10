using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Library
{
    // Shopping list class which will be serialized
    [XmlRoot("SaveGameList")]
    public class SaveGameList
    {
        [XmlElement("mySavedGames")]
        private ArrayList mySaveGameList;

        public SaveGameList()
        {
            mySaveGameList = new ArrayList();
        }
        
        public int GetLastID()
        {
            int MAX = -1;
            for (int i = 0; i < myGames.Length; i++)
            {
                if (myGames[i].SaveGameID > MAX)
                {
                    MAX = myGames[i].SaveGameID;
                }
            }
            return MAX;
        }


        public SaveGame[] myGames
        {
            get
            {
                SaveGame[] myGames = new SaveGame[mySaveGameList.Count];
                mySaveGameList.CopyTo(myGames);
                return myGames;
            }
            set
            {
                if (value == null)
                    return;
                SaveGame[] mySavedGames = (SaveGame[])value;
                mySaveGameList.Clear();
                foreach (SaveGame mySaveGame in mySavedGames)
                    mySaveGameList.Add(mySaveGame);
            }
        }

        public Boolean AddItem(SaveGame mySaveGame)
        {
            try
            {
                mySaveGameList.Add(mySaveGame);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Adding Game: " + ex.Message.ToString());
                return false;
            }
        }

        public void RemoveItem(int SaveGameIndex)
        {
            mySaveGameList.RemoveAt(SaveGameIndex);
        }

    }



}