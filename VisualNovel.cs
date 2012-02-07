using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine
{
    class VisualNovel
    {
        public VisualNovel()
        {
            //Create a new game from nothing.
        }

        public VisualNovel(SavedGame gamefile)
        {
            //Load a game from a saved game file
        }
    }

    //A simple object to represent a saved game state
    struct SavedGame
    {
        public SavedGame()
        {
        }
    }
}
