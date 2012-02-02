﻿using System;
using System.Collections.Generic;
using System.Text;


using System.Data;

namespace DreamQs
{
    class Character
    {
        //This character's name
        protected string mName;

        protected Stat[] mStats;

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

        public Stat[] stats
        {
            set { mStats = value; }
            get { return mStats; }
        }
    }
}
