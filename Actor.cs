using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine
{
    class Actor
    {
        //This character's name
        protected string mName;

        public Actor()
        {
        }

        public Actor(string name)
        {
            mName = name;
        }

        //Getters and setters for character name
        public string name
        {
            set { mName = value; }
            get { return mName; }
        }
    }
}
