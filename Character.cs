using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine.Character
{
    class Character : Actor
    {
        //A list of the character's stats
        protected Dictionary<string, int> mStats;

        public Character()
        {
        }

        public Character(string name)
        {
            mName = name;
        }

        public Dictionary<string, int> stats
        {
            set { mStats = value; }
            get { return mStats; }
        }
    }
}
