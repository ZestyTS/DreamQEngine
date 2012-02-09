using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine.Character
{
    public class VisualNovelGame : VisualNovel
    {
        public VisualNovelGame(string gameData) : base(gameData)
        {
            //Create a new game from a database file
        }

        public VisualNovelGame(string gameData, string savedGame) : base(gameData, savedGame)
        {
            //Load a game from a saved game file
        }
    }
}
