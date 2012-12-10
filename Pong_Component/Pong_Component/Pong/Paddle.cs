using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong_Component
{
    class Paddle
    {
        Vector2 myVector;
        float moveFactorPerSecond;

        
        public Paddle(float X, float Y, float movefactor)
        {
            myVector = new Vector2(X, Y);
            moveFactorPerSecond = movefactor;
            
        }

        public void MoveUp()
        {
            myVector.Y += moveFactorPerSecond;
            Check();
        }

        public void MoveDown()
        {            
            myVector.Y -= moveFactorPerSecond;
            Check();
        }

        public void Check()
        {
            if (myVector.Y < 3)
                myVector.Y = 3;
            if (myVector.Y > 516)
                myVector.Y = 516;
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

        public float movefactor
        {
            set
            {
                moveFactorPerSecond  = value;
            }
            get
            {
                return moveFactorPerSecond;
            }
        }

    }
}
