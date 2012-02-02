using System;
using System.Collections.Generic;
using System.Text;


using System.Data;

namespace DreamQs
{
    class Stat
    {
        //This stat's name (Strength, Intelligence, etc)
        protected string mName;

        //The value stored in this stat
        protected int mValue;

        public Stat(string name)
        {
            mName = name;
        }

        public string name
        {
            set { mName = value; }
            get { return mName; }
        }

        public int value
        {
            set { mValue = value; }
            get { return mValue; }
        }
    }
}