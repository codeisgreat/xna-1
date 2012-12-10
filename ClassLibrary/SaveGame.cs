using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class SaveGame
    {
        public int SaveGameID = 0;
        public String Player1_Name="";
        public int Player1_Score=0;
        public String Player2_Name="";
        public int Player2_Score=0;

        public double BallSpeed_X=0.0;
        public double BallSpeed_Y=0.0;

        //public SaveGame(String P1Name, int P1Score, String P2Name, int P2Score, double Ball_X, double Ball_Y)
        //{
        //    Player1_Name = P1Name;
        //    Player2_Name = P2Name;
        //    Player1_Score = P1Score;
        //    Player2_Score = P2Score;
        //    BallSpeed_X = Ball_X;
        //    BallSpeed_Y = Ball_Y;            
        //}

        public override string ToString()
        {
            return "Player1: " + Player1_Name + "(" + Player1_Score + "), Player2: " + Player2_Name + "(" + Player2_Score + ")";                
        }

    }
}
