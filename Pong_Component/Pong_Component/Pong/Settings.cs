using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Class_Library;

namespace Pong_Component
{


    public class Settings
    {
        public bool QuickPlay = Helper.GetQuickPlayOption();
        public bool ActiveObstacle = Helper.GetObstacleOption();
        public bool ObstacleGoingUp = true;

        public int MaxWidth = 800;
        public int MaxHeight = 600;
        public int ScoreToWin = 1;
        public int NumberOfPlayers = 2;

        public double TransitionOnTime = 1.5;
        public double TransitionOffTime = 0.5;

        public Venue myVenue = (Venue)Helper.GetVenue();

        public int InitPosX = 100;
        public int InitPosY = 100;
        public int PaddleMoveFactor = 6;


    }
}
