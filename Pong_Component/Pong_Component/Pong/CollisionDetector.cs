using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong_Component
{
    class CollisionDetector
    {
        public bool hitobst = false;
        public bool hitpaddle = false;
      
        //paddleid 1=right paddle, 2 == left paddle
        public CollisionDetector(Ball BallPosition, Paddle PaddlePosition, int paddleId)
        {
            hitpaddle = false;
           
            Rectangle BallRectangle = new Rectangle((int)BallPosition.X-2, (int)BallPosition.Y-2, 22, 22);
            Rectangle PaddleRectangle1 = new Rectangle((int)PaddlePosition.X-2, (int)PaddlePosition.Y - 5, 18, 20);
            Rectangle PaddleRectangle2 = new Rectangle((int)PaddlePosition.X-2, (int)PaddlePosition.Y + 15, 18, 15);
            Rectangle PaddleRectangle3 = new Rectangle((int)PaddlePosition.X-2, (int)PaddlePosition.Y + 30, 18, 10);
            Rectangle PaddleRectangle4 = new Rectangle((int)PaddlePosition.X-2, (int)PaddlePosition.Y + 40, 18, 15);
            Rectangle PaddleRectangle5 = new Rectangle((int)PaddlePosition.X-2, (int)PaddlePosition.Y + 45, 18, 20);

            if (BallRectangle.Intersects(PaddleRectangle2) || BallRectangle.Intersects(PaddleRectangle4))
            {
                hitpaddle = true;
                if(paddleId ==1)
                    BallPosition.XSpeedFactor = -1 * Math.Abs(BallPosition.XSpeedFactor);
                else if(paddleId ==2)
                    BallPosition.XSpeedFactor = 1 * Math.Abs(BallPosition.XSpeedFactor);
            }
            else if (BallRectangle.Intersects(PaddleRectangle1) || BallRectangle.Intersects(PaddleRectangle5))
            {
                hitpaddle = true;
                if (paddleId == 1)
                {
                     BallPosition.XSpeedFactor = -1 * Math.Abs(BallPosition.XSpeedFactor);
                    if ((BallPosition.YSpeedFactor < 8) && (BallPosition.YSpeedFactor > 0))
                        BallPosition.YSpeedFactor += 1;
                    else if((BallPosition.YSpeedFactor>-8)&&(BallPosition.YSpeedFactor<0))
                        BallPosition.YSpeedFactor -=1;
                    if(BallPosition.XSpeedFactor >-7)
                        BallPosition.XSpeedFactor -=2;
                }

                else if (paddleId == 2)
                {
                    BallPosition.XSpeedFactor = 1 * Math.Abs(BallPosition.XSpeedFactor);

                    if ((BallPosition.YSpeedFactor < 8) && (BallPosition.YSpeedFactor > 0))
                    BallPosition.YSpeedFactor = BallPosition.YSpeedFactor + 1;
                else if ((BallPosition.YSpeedFactor > -8) && (BallPosition.YSpeedFactor < 0))
                    BallPosition.YSpeedFactor -=  1;

                if (BallPosition.XSpeedFactor < 7)
                    BallPosition.XSpeedFactor +=  2;
                }
            }
            else if (BallRectangle.Intersects(PaddleRectangle3))
            {
                hitpaddle = true;
                if (paddleId == 1)
                    BallPosition.XSpeedFactor = -1 * Math.Abs(BallPosition.XSpeedFactor);
                else if (paddleId == 2)
                {
                    BallPosition.XSpeedFactor = 1 * Math.Abs(BallPosition.XSpeedFactor);
                   
                    if (BallPosition.YSpeedFactor > 4)
                        BallPosition.YSpeedFactor -= 1;
                    else if (BallPosition.YSpeedFactor < -4)
                        BallPosition.YSpeedFactor +=  1;

                    if (BallPosition.XSpeedFactor > 4)
                        BallPosition.XSpeedFactor = BallPosition.XSpeedFactor - 1;
                }
            }
        }
   

        public CollisionDetector(Ball BallPosition, Obstacle ObstaclePosition)
        {
            
            hitobst = false;

            Rectangle ObstacleRectangleLeftSide = new Rectangle((int)(ObstaclePosition.X - 11), (int)ObstaclePosition.Y, 10, 160);
            Rectangle ObstacleRectangleRightSide = new Rectangle((int)(ObstaclePosition.X + 8), (int)ObstaclePosition.Y, 5, 160);
            Rectangle BallRectangle = new Rectangle((int)BallPosition.X - 10, (int)BallPosition.Y - 10, 20, 20);
            int temp = BallPosition.XSpeedFactor;
            if (BallRectangle.Intersects(ObstacleRectangleLeftSide))
                BallPosition.XSpeedFactor = -1 * (Math.Abs(BallPosition.XSpeedFactor));
            else if (BallRectangle.Intersects(ObstacleRectangleRightSide))
                BallPosition.XSpeedFactor = Math.Abs(BallPosition.XSpeedFactor);
            if (temp != BallPosition.XSpeedFactor)
                hitobst = true;
                

            
        }
    }
}
