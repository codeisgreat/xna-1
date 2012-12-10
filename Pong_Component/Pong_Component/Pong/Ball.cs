using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Pong_Component
{
    class Ball
    {
        Vector2 myVector;

        public int YSpeedFactor = 2;
        public int XSpeedFactor = 4;
        
        public Ball(float X, float Y)
        {
            myVector = new Vector2(X, Y);
        }

       
        public void Check()
        {
            if (myVector.Y < 3)
                myVector.Y = 3;
            if (myVector.Y > 516)
                myVector.Y = 516;
        }




        public void reset()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int direction = rnd.Next(4);
            if (direction == 0)
            {
                YSpeedFactor = 2;
                XSpeedFactor = 4;
            }
            else if (direction == 1)
            {
                YSpeedFactor = -2;
                XSpeedFactor = 4;
            }
            else if (direction == 2)
            {
                YSpeedFactor = 2;
                XSpeedFactor = -4;
            }
            else if (direction == 3)
            {
                YSpeedFactor = -2;
                XSpeedFactor = -4;
            }

            X = 400 - 10;
            Y = 300 - 10;

        }
        public float X
        {
            set
            {
                myVector.X = value;
            }
            get
            {
                return myVector.X;
            }
        }

        public float Y
        {
            set
            {
                myVector.Y = value;
            }
            get
            {
                return myVector.Y;
            }
        }
    }

}
