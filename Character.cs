using System;
using System.Collections.Generic;
using System.Text;


using System.Data;

namespace DreamQEngine.Character
{
    class Character
    {
        //This character's name
        protected string mName;

        //A list of the character's stats
        protected Dictionary<string, int> mStats;

        public Character()
        {
        }

        public Character(string name)
        {
            mName = name;
        }

        //Getters and setters for popularity
        public string name
        {
            set { mName = value; }
            get { return mName; }
        }

        public Dictionary<string, int> stats
        {
            set { mStats = value; }
            get { return mStats; }
        }
    }
}
