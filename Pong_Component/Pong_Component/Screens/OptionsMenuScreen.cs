#region File Description
//-----------------------------------------------------------------------------
// OptionsMenuScreen.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using Microsoft.Xna.Framework;
#endregion
using Class_Library;

namespace Pong_Component
{
    /// <summary>
    /// The options screen is brought up over the top of the main menu
    /// screen, and gives the user a chance to configure the game
    /// in various hopefully useful ways.
    /// </summary>
    class OptionsMenuScreen : MenuScreen
    {
        #region Fields
       
        MenuEntry VenueMenuEntry;
        MenuEntry SoundMenuEntry;
        MenuEntry ObstacleMenuEntry;

  
  
        static string[] Venue = { "Indoor", "Outdoor", "Random" };
        
        static int currentVenue = Helper.GetVenue();
        static bool Sound = true;
        static bool Obstacle = Helper.GetObstacleOption();
        #endregion

        #region Initialization


        /// <summary>
        /// Constructor.
        /// </summary>
        public OptionsMenuScreen()
            : base("Options")
        {
            // Create our menu entries.
            VenueMenuEntry = new MenuEntry(string.Empty);
            ObstacleMenuEntry = new MenuEntry(string.Empty);
            SoundMenuEntry = new MenuEntry(string.Empty);
            
            
            SetMenuEntryText();

            MenuEntry backMenuEntry = new MenuEntry("Back");

            // Hook up menu event handlers.
            VenueMenuEntry.Selected += VenueMenuEntrySelected;
            ObstacleMenuEntry.Selected += ObstacleMenuEntrySelected;
            SoundMenuEntry.Selected += SoundMenuEntrySelected;
            backMenuEntry.Selected += OnCancel;
       
            
            // Add entries to the menu.
            MenuEntries.Add(VenueMenuEntry);
            MenuEntries.Add(ObstacleMenuEntry);
            MenuEntries.Add(SoundMenuEntry);
            MenuEntries.Add(backMenuEntry);
        }

        
        /// <summary>
        /// Fills in the latest values for the options screen menu text.
        /// </summary>
        void SetMenuEntryText()
        {
            VenueMenuEntry.Text = "Venue: " + (Venue)Helper.GetVenue();
            SoundMenuEntry.Text = "Sound: " + (Sound ? "On" : "Off");
            ObstacleMenuEntry.Text = "Obstacle: " + (Obstacle ? "On" : "Off");
        }


        #endregion

        #region Handle Input



        /// <summary>
        /// Event handler for when the Venue  change .
        /// </summary>
        void VenueMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            AudioManager.PlayCue("Menu_Accept");
            currentVenue = (currentVenue + 1) % Venue.Length;
            Helper.SetVenue(currentVenue);
            SetMenuEntryText();
        }


        /// <summary>
        /// Event handler for when the Sound menu entry is selected.
        /// </summary>
        void SoundMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            AudioManager.PlayCue("Menu_Accept");
            Sound = !Sound;
            SetMenuEntryText();
        }


        /// <summary>
        /// Event handler for when the Obstacle menu entry is selected.
        /// </summary>
        void ObstacleMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            AudioManager.PlayCue("Menu_Accept");            
            Obstacle = !Obstacle;
            Class_Library.Helper.SetObstacleOption(Obstacle);
            SetMenuEntryText();
        }



        #endregion
    }
}
//Obstacle