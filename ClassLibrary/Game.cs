using System;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Library
{
    public class Game
    {
        [XmlAttribute("GameID")]
        public int GameID = 1;

        [XmlAttribute("Player1")]
        public String Player1_Name = "";

        [XmlAttribute("Player2")]
        public String Player2_Name = "";

        [XmlAttribute("Player1_Score")]
        public int Player1_Score = 0;

        [XmlAttribute("Player2_Score")]
        public int Player2_Score = 0;

        [XmlAttribute("TimeDuration")]
        public int TimeDuration = 0;

        [XmlAttribute("IsVisible")]
        public Boolean IsVisible = true;
        
        public Game()
        { }

        public Game(int ID, String Player1, int Player1Score, String Player2, int Player2Score, int TimeTaken)
        {
            GameID = ID;
            Player1_Name = Player1;
            Player1_Score = Player1Score;
            Player2_Name = Player2;
            Player2_Score = Player2Score;
            TimeDuration = TimeTaken;
            IsVisible = true;
        }

        public String Winner()
        {
            if (Player1_Score > Player2_Score)
            {
                return Player1_Name;
            }
            else
            {
                return Player2_Name;
            }
        }

        public override string ToString()
        {
            return "GameID: ," + GameID.ToString() + ", Duration: " + TimeDuration.ToString() + ", Between " + Player1_Name + " and " + Player2_Name; 
        }

    }
}
