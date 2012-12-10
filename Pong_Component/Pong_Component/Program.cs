using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Class_Library;

namespace Pong_Component
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    public class Program
    {
        public delegate void GameEndedHandler(Object cmd);
        public event GameEndedHandler GameEnded;
       // public Settings mySettings;

        public Program()
        {

        }

        public void PlayMusicTitle()
        {
            AudioManager.PlayMusic("Music_Title");
        }

        public void Init()
        {
            try
            {
                Pong_ComponentGame game = new Pong_ComponentGame();
                game.Run();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
                //Generate Finished Event Handler
            }
            finally
            {
                if (GameEnded != null)
                    GameEnded("Pass the Game Score back through this");
            }
        }

        public static void Main()
        {
           // Pong_ComponentGame game = new Pong_ComponentGame();
           // game.Run();
            //Do NOT delete this method. Even though its empty it needs to Exist. 
        }


    }
}
