#region File Description
//-----------------------------------------------------------------------------
// PauseMenuScreen.cs
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
    /// The pause menu comes up over the top of the game,
    /// giving the player options to resume or quit.
    /// </summary>
    class PauseMenuScreen : MenuScreen
    {
        #region Initialization


        /// <summary>
        /// Constructor.
        /// </summary>
        public PauseMenuScreen()
            : base("Paused")
        {
            // Flag that there is no need for the game to transition
            // off when the pause menu is on top of it.
            IsPopup = true;

            // Create our menu entries.
            MenuEntry resumeGameMenuEntry = new MenuEntry("Resume Game");
            MenuEntry saveGameMenuEntry = new MenuEntry("Save Game");
            MenuEntry concedeGameMenuEntry = new MenuEntry("Concede Game");
            MenuEntry quitGameMenuEntry = new MenuEntry("Quit Game");
            
            // Hook up menu event handlers.
            resumeGameMenuEntry.Selected += OnCancel;
            quitGameMenuEntry.Selected += QuitGameMenuEntrySelected;
            saveGameMenuEntry.Selected += SaveGameMenuEntrySelected;
            concedeGameMenuEntry.Selected += ConcedeGameMenuEntrySelected;


            // Add entries to the menu.
            MenuEntries.Add(resumeGameMenuEntry);
            MenuEntries.Add(saveGameMenuEntry);
            MenuEntries.Add(concedeGameMenuEntry);
            MenuEntries.Add(quitGameMenuEntry);

        }


        #endregion

        #region Handle Input


        /// <summary>
        /// Event handler for when the Quit Game menu entry is selected.
        /// </summary>
        void QuitGameMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            const string message = "Quit this game?";
            MessageBoxScreen confirmQuitMessageBox = new MessageBoxScreen(message);
            confirmQuitMessageBox.Accepted += ConfirmQuitMessageBoxAccepted;
            ScreenManager.AddScreen(confirmQuitMessageBox, ControllingPlayer);
        }

        /// <summary>
        /// Event handler for when the Save Game menu entry is selected.
        /// </summary>
        void SaveGameMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            const string message = "Save Current Game?";
            MessageBoxScreen confirmSaveMessageBox = new MessageBoxScreen(message);
            confirmSaveMessageBox.Accepted += confirmSaveMessageBoxAccepted;
            ScreenManager.AddScreen(confirmSaveMessageBox, ControllingPlayer);
        }

        /// <summary>
        /// This is Fired when the Save Message Box is Fired
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void confirmSaveMessageBoxAccepted(object sender, PlayerIndexEventArgs e)
        {
            //Transfer SaveTempGame (saveGame.xml) to SaveGameList
            SaveGame myTempGame = new SaveGame();
            XMLHelper<SaveGame> TempXML = new XMLHelper<SaveGame>();
            TempXML.Load(ref myTempGame);

            SaveGameList mySaveGameList = new SaveGameList();
            XMLHelper<SaveGameList> SaveGameXML = new XMLHelper<SaveGameList>();
            SaveGameXML.Load(ref mySaveGameList);

            mySaveGameList.AddItem(myTempGame);
            SaveGameXML.Save(mySaveGameList);

            LoadingScreen.Load(ScreenManager, false, null, new BackgroundScreen(), new MainMenuScreen());

        }

        /// <summary>
        /// Event handler for when the Concede Game menu entry is selected.
        /// </summary>
        void ConcedeGameMenuEntrySelected(object sender, PlayerIndexEventArgs e)
        {
            const string message = "Concede this game?";
            MessageBoxScreen confirmQuitMessageBox = new MessageBoxScreen(message);
            confirmQuitMessageBox.Accepted += ConfirmQuitMessageBoxAccepted;
            ScreenManager.AddScreen(confirmQuitMessageBox, ControllingPlayer);
        }

        /// <summary>
        /// Event handler for when the user selects ok on the "are you sure
        /// you want to quit" message box. This uses the loading screen to
        /// transition from the game back to the main menu screen.
        /// </summary>
        void ConfirmQuitMessageBoxAccepted(object sender, PlayerIndexEventArgs e)
        {
            LoadingScreen.Load(ScreenManager, false, null, new BackgroundScreen(),
                                                           new MainMenuScreen());
        }


        #endregion

        #region Draw


        /// <summary>
        /// Draws the pause menu screen. This darkens down the gameplay screen
        /// that is underneath us, and then chains to the base MenuScreen.Draw.
        /// </summary>
        public override void Draw(GameTime gameTime)
        {
            ScreenManager.FadeBackBufferToBlack(TransitionAlpha * 2 / 3);

            base.Draw(gameTime);
        }


        #endregion
    }
}
