using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SQLite;
using System.Data;

namespace DreamQs
{
    class Dialogue
    {
        //The text of the dialogue presented
        protected string mText;

        //The NPC saying this dialogue
        protected Character mActor;

        //The choices presented to you at the end of the dialogue
        protected Choice[] mChoices;

        public Dialogue()
        {
        }

        public string text
        {
            set { mText = value; }
            get { return mText; }
        }

        public Choice[] choices
        {
            set { mChoices = value; }
            get { return mChoices; }
        }

        public Character actor
        {
            set { mActor = value; }
            get { return mActor; }
        }
    }
}
