using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine.Character
{
    class Character : Actor
    {
        //A list of the character's stats
        protected Dictionary<string, int> mStats;

        public Character(string name)
            :base(name)
        {
        }

        public Character(string name, Dictionary<string, int> stats)
            : this(name)
        {
            mStats = stats;
        }

        public Dictionary<string, int> stats
        {
            set { mStats = value; }
            get { return mStats; }
        }
    }
}
