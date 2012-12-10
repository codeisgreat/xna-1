#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;

using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using System.Threading;
using Class_Library;

#endregion

namespace Pong_Component
{

    class ComputerPong : GameScreen
    {
        //Load Game Settings
        Settings mySettings = new Settings();

        GamePlayers myPlayers;
        XMLHelper<GamePlayers> myPlayersXML;
        GameHistory myGameList;
        XMLHelper<GameHistory> myGameHistoryXML;

        SaveGame myLatestSave;
        XMLHelper<SaveGame> mySaveGameXML;

        //Init Content
        ContentManager content;
        SpriteFont gameFont;
        SpriteFont font;
        Random random = new Random();
        SpriteBatch spriteBatch;
        Texture2D backgroundTexture, TextureBall, TextureObstacle;
        Texture2D TextureLeftPaddle, TextureRightPaddle;

        //Init Game Objects
        Paddle LeftPaddlePosition;
        Paddle RightPaddlePosition;
        Vector2 playerPosition;
        Vector2 enemyPosition;
        Obstacle ObstaclePosition;
        Ball BallPosition;

        //Player Points
        int Player_1_Points = 0;
        int Player_2_Points = 0;

        DateTime myGameTime;

        public ComputerPong()
        {
            myLatestSave = new SaveGame();
            mySaveGameXML = new XMLHelper<SaveGame>(); 

            myGameTime = DateTime.Now;

            //Transition Time
            TransitionOnTime = TimeSpan.FromSeconds(mySettings.TransitionOnTime);
            TransitionOffTime = TimeSpan.FromSeconds(mySettings.TransitionOffTime);

            //Load Player Info
            myPlayers = new GamePlayers();
            myPlayersXML = new XMLHelper<GamePlayers>();
            myPlayersXML.Load(ref myPlayers);

            //Load GameHistory
            myGameHistoryXML = new XMLHelper<GameHistory>();
            myGameList = new GameHistory();
            myGameHistoryXML.Load(ref myGameList);
            

            //Load Game Objects
            ObstaclePosition = new Obstacle(mySettings.MaxWidth / 2 - 10, mySettings.MaxHeight / 2 - 80);
            BallPosition = new Ball(mySettings.MaxWidth / 2 - 10, mySettings.MaxHeight / 2 - 10);
            RightPaddlePosition = new Paddle(mySettings.MaxWidth - 25, mySettings.MaxHeight / 2 - 40, mySettings.PaddleMoveFactor);
            LeftPaddlePosition = new Paddle(10, mySettings.MaxHeight / 2 - 40, mySettings.PaddleMoveFactor);
            playerPosition = new Vector2(mySettings.InitPosX, mySettings.InitPosY);
            enemyPosition = new Vector2(mySettings.InitPosX, mySettings.InitPosY);

            //Check if Both Users are In System or if Quick Play is Enabled
            if (myPlayers.myPlayers.Length != mySettings.NumberOfPlayers && !mySettings.QuickPlay)
                throw new Exception("There Need to be " + mySettings.NumberOfPlayers + " Active users in the system");

        }

        /// <summary>
        /// Helps Load Initial Game Content, Sprite, Ball, Paddle, Obstacle Objects from Content
        /// </summary>
        public override void LoadContent()
        {
            if (content == null)
                content = new ContentManager(ScreenManager.Game.Services, "Content");

            if (mySettings.myVenue == Venue.Indoor)
                backgroundTexture = content.Load<Texture2D>("PongTableTop");
            else
                backgroundTexture = content.Load<Texture2D>("Backyard");

            TextureBall = content.Load<Texture2D>("Ball");
            TextureLeftPaddle = content.Load<Texture2D>("LeftPaddle");
            TextureRightPaddle = content.Load<Texture2D>("RightPaddle");
            TextureObstacle = content.Load<Texture2D>("Obstacle");

            font = content.Load<SpriteFont>("myFont");
            gameFont = content.Load<SpriteFont>("gamefont");
            Thread.Sleep(1000);

            ScreenManager.Game.ResetElapsedTime();
        }

        /// <summary>
        /// A Virtual Destructor, invoked to Clear Content Objects, Reset to Null
        /// </summary>
        public void UnloadContent()
        {
            content.Unload();
        }

        void WinningMessageBoxAccepted(object sender, PlayerIndexEventArgs e)
        {
            LoadingScreen.Load(ScreenManager, false, null, new BackgroundScreen(), new MainMenuScreen());
        }

        public override void HandleInput(InputState input)
        {
            String Message = "";
            if (input == null)
                throw new ArgumentNullException("input");
            int playerIndex = (int)ControllingPlayer.Value;
            KeyboardState keyboardState = input.CurrentKeyboardStates[playerIndex];

            if (input.IsPauseGame(ControllingPlayer))
            {
                ScreenManager.AddScreen(new PauseMenuScreen(), ControllingPlayer);
            }
            else if (Player_1_Points >= mySettings.ScoreToWin)
            {
                AudioManager.PlayCue("Music_Win");
                if (!mySettings.QuickPlay)
                {
                    //Update Player Information
                    myPlayers.myPlayers[0].Won();
                    myPlayers.myPlayers[1].Lost();
                    myPlayersXML.Save(myPlayers);
                    Message = myPlayers.myPlayers[0].UserName + " Win!";
                    //Update Game History
                    Class_Library.Game myGame = new Class_Library.Game();
                    myGame.GameID = myGameList.GetLastID() + 1;
                    myGame.Player1_Name = myPlayers.myPlayers[0].UserName;
                    myGame.Player2_Name = myPlayers.myPlayers[1].UserName;
                    myGame.Player1_Score = Player_1_Points;
                    myGame.Player2_Score = Player_2_Points;
                    myGameList.AddItem(myGame);
                    myGameHistoryXML.Save(myGameList);

                    //New Code Added
                    myLatestSave.Player1_Name = myPlayers.myPlayers[0].UserName;
                    myLatestSave.Player2_Name = myPlayers.myPlayers[1].UserName;

                    myLatestSave.Player1_Score = Player_1_Points;
                    myLatestSave.Player2_Score = Player_2_Points;
                    myLatestSave.BallSpeed_X = BallPosition.XSpeedFactor;
                    myLatestSave.BallSpeed_Y = BallPosition.YSpeedFactor;
                    mySaveGameXML.Save(myLatestSave);
                }
                else
                {
                    Message = "Artificial Intelligence Beat you. Too Bad";
                }
                 
                MessageBoxScreen WinningMessageBox = new MessageBoxScreen(Message, false);
                WinningMessageBox.Accepted += WinningMessageBoxAccepted;
                ScreenManager.AddScreen(WinningMessageBox, ControllingPlayer);
            }
            else if (Player_2_Points >= mySettings.ScoreToWin)
            {
                AudioManager.PlayCue("Music_Win");
                if (!mySettings.QuickPlay)
                {
                    TimeSpan GameDuration = new TimeSpan();
                    GameDuration = DateTime.Now - myGameTime;

                    myPlayers.myPlayers[0].Lost();
                    myPlayers.myPlayers[1].Won();
                    myPlayersXML.Save(myPlayers);
                    Message = myPlayers.myPlayers[1].UserName + " Win!";

                    Class_Library.Game myGame = new Class_Library.Game();
                    myGame.GameID = myGameList.GetLastID() +1;
                    myGame.Player1_Name = myPlayers.myPlayers[0].UserName;
                    myGame.Player2_Name = myPlayers.myPlayers[1].UserName;
                    myGame.Player1_Score = Player_1_Points;
                    myGame.Player2_Score = Player_2_Points;
                    myGame.TimeDuration = Convert.ToInt32(GameDuration.TotalSeconds);
                    myGameList.AddItem(myGame);
                    myGameHistoryXML.Save(myGameList);

                    //New Code Added
                    myLatestSave.Player1_Name = myPlayers.myPlayers[0].UserName;
                    myLatestSave.Player2_Name = myPlayers.myPlayers[1].UserName;

                    myLatestSave.Player1_Score = Player_1_Points;
                    myLatestSave.Player2_Score = Player_2_Points;
                    myLatestSave.BallSpeed_X = BallPosition.XSpeedFactor;
                    myLatestSave.BallSpeed_Y = BallPosition.YSpeedFactor;
                    mySaveGameXML.Save(myLatestSave);
                }
                else
                {
                    Message = "Congratulations, you Beat the Computer";
                }

                MessageBoxScreen WinningMessageBox = new MessageBoxScreen(Message, false);
                WinningMessageBox.Accepted += WinningMessageBoxAccepted;
                ScreenManager.AddScreen(WinningMessageBox, ControllingPlayer);
            }
            else
            {
                //determine how fast the paddle will move
                if (keyboardState.IsKeyDown(Keys.Up))
                    RightPaddlePosition.MoveDown();
                if (keyboardState.IsKeyDown(Keys.Down))
                    RightPaddlePosition.MoveUp();

                if (mySettings.QuickPlay)
                {
                    int temp = (int)BallPosition.YSpeedFactor;
                    if (temp > 5)
                        temp = 5;
                    LeftPaddlePosition.movefactor = temp;

                    if (BallPosition.Y > LeftPaddlePosition.Y)
                        LeftPaddlePosition.MoveUp();
                    else if (BallPosition.Y < LeftPaddlePosition.Y)
                        LeftPaddlePosition.MoveDown();
                }
                else
                {
                    if (keyboardState.IsKeyDown(Keys.W))
                        LeftPaddlePosition.MoveDown();
                    if (keyboardState.IsKeyDown(Keys.S))
                        LeftPaddlePosition.MoveUp();
                }
            }
        }

        /// <summary>
        /// Displays Updated Score inside of the Game Loop
        /// </summary>
        public void ShowScore()
        {
            spriteBatch.Begin();
            if (mySettings.QuickPlay)
            {
                spriteBatch.DrawString(font, "Artificial Intelligence " + " : " + Player_1_Points.ToString(), new Vector2(55, 5), Color.White);
                spriteBatch.DrawString(font, "Test Player" + " : " + Player_2_Points.ToString(), new Vector2(650, 5), Color.White);
            }
            else
            {
                spriteBatch.DrawString(font, myPlayers.myPlayers[0].UserName + " : " + Player_1_Points.ToString(), new Vector2(55, 5), Color.White);
                spriteBatch.DrawString(font, myPlayers.myPlayers[1].UserName + " : " + Player_2_Points.ToString(), new Vector2(650, 5), Color.White);
            }
            spriteBatch.End();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameTime"></param>
        /// <param name="otherScreenHasFocus"></param>
        /// <param name="coveredByOtherScreen"></param>
        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {
            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
            if (IsActive)
            {
                MoveBall();
                if (mySettings.ActiveObstacle)
                    MoveObstacle();
            }
        }

        /// <summary>
        /// MoveBall Method
        /// </summary>
        bool flag1 = false;
        protected void MoveBall()
        {
            //paddleid 1=right paddle, 2 == left paddle
            CollisionDetector ColliteLeftpaddle = new CollisionDetector(BallPosition, LeftPaddlePosition, 2);
            CollisionDetector ColliteRightpaddle = new CollisionDetector(BallPosition, RightPaddlePosition, 1);
            if (ColliteLeftpaddle.hitpaddle || ColliteRightpaddle.hitpaddle)
            {
                AudioManager.PlayCue("HitPaddle");
                flag1 = true;
            }
            if (mySettings.ActiveObstacle)
            {
                CollisionDetector CollitetoObstacle = new CollisionDetector(BallPosition, ObstaclePosition);
                if (CollitetoObstacle.hitobst && flag1)
                {
                    AudioManager.PlayCue("HitObs");
                    flag1 = false;
                }
            }

            BallPosition.X += 1 * BallPosition.XSpeedFactor;
            BallPosition.Y += 1 * BallPosition.YSpeedFactor;

            // Keep the ball inside of the frame
            if (BallPosition.Y < 5 || BallPosition.Y > 575)
            {
                BallPosition.YSpeedFactor = -BallPosition.YSpeedFactor;
                AudioManager.PlayCue("HitBorder");
            }

            //if Ball Lost
            else if (BallPosition.X < 0 || BallPosition.X > 800)
            {
                AudioManager.PlayCue("Drop");
                if (BallPosition.X < 0)
                {
                    Player_2_Points++;
                }
                else
                {
                    Player_1_Points++;
                }
                BallPosition.reset();
            }
        }

        /// <summary>
        /// Move Obstacle
        /// </summary>
        public void MoveObstacle()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int increment = rnd.Next(6);
            if (mySettings.ObstacleGoingUp)
                ObstaclePosition.Y = ObstaclePosition.Y - increment;
            else
                ObstaclePosition.Y = ObstaclePosition.Y + increment;
            if (ObstaclePosition.Y < 10)
                mySettings.ObstacleGoingUp = false;
            else if (ObstaclePosition.Y > 420)
                mySettings.ObstacleGoingUp = true;

        }

        /// <summary>
        /// The Size of the Ball.png is 20X20 pixel
        /// </summary>
        protected void DrawBall()
        {
            spriteBatch.Begin();
            spriteBatch.Draw(TextureBall, new Rectangle((int)BallPosition.X, (int)BallPosition.Y, 20, 20), Color.LightGray);
            spriteBatch.End();
        }

        /// <summary>
        ///  The Size of the paddles is 15X80 pixel
        /// </summary>
        protected void DrawPaddles()
        {
            spriteBatch.Begin();
            spriteBatch.Draw(TextureLeftPaddle, new Rectangle((int)LeftPaddlePosition.X, (int)LeftPaddlePosition.Y, 15, 80), Color.LightGray);
            spriteBatch.Draw(TextureRightPaddle, new Rectangle((int)RightPaddlePosition.X, (int)RightPaddlePosition.Y, 15, 80), Color.LightGray);
            spriteBatch.End();
        }

        /// <summary>
        /// Size is
        /// </summary>
        protected void DrawObstacle()
        {
            if (mySettings.ActiveObstacle)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(TextureObstacle, new Rectangle((int)ObstaclePosition.X, (int)ObstaclePosition.Y, 20, 160), Color.LightGray);
                spriteBatch.End();
            }
        }

        public override void Draw(GameTime gameTime)
        {
            // This game has a blue background. Why? Because!
            ScreenManager.GraphicsDevice.Clear(ClearOptions.Target, Color.CornflowerBlue, 0, 0);

            // Our player and enemy are both actually just text strings.
            spriteBatch = ScreenManager.SpriteBatch;
            spriteBatch.Begin();
            spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, mySettings.MaxWidth, mySettings.MaxHeight), Color.LightGray);

            spriteBatch.End();

            //Draw Ball
            DrawBall();

            //Draw Paddles
            DrawPaddles();

            DrawObstacle();
            //Show Score
            ShowScore();
            // If the game is transitioning on or off, fade it out to black.
            if (TransitionPosition > 0)
                ScreenManager.FadeBackBufferToBlack(255 - TransitionAlpha);
        }


    }
}
