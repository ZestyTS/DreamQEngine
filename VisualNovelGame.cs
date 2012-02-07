using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine.Character
{
    class VisualNovelGame : VisualNovel
    {
        public VisualNovelGame()
        {
            //Create a new game from nothing.
        }

        public VisualNovelGame(string playerName)
        {
            //Create a new game with a character
        }

        public VisualNovelGame(SavedGame gamefile)
        {
            //Load a game from a saved game file
        }
    }
}
