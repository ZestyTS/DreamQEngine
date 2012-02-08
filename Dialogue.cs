using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine
{
    class Dialogue
    {
        //The text of the dialogue presented
        protected string mText;

        //The NPC saying this dialogue
        protected Actor mActor;

        //The choices presented to you at the end of the dialogue
        protected Option[] mChoices;

        public Dialogue()
        {
        }

        public string text
        {
            set { mText = value; }
            get { return mText; }
        }

        public Option[] choices
        {
            set { mChoices = value; }
            get { return mChoices; }
        }

        public Actor actor
        {
            set { mActor = value; }
            get { return mActor; }
        }
    }
}