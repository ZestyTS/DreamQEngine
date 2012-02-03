using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace DreamQs
{
    class Player : Character
    {
        public Player(string name):base(name)
        {
        }

        public Player(SavedGame saveFile)
        {
            mName = saveFile.playerName;
        }
    }
}
