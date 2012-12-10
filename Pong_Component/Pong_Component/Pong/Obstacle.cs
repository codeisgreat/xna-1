using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong_Component
{

    class Obstacle
    {
        Vector2 myVector;
  

        public Obstacle(float X, float Y)
        {
            myVector = new Vector2(X, Y);
          
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
