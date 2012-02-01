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

        public void makeChoice(int choiceIndex)
        {
            Choice choiceMade = mChoices[choiceIndex];
        }
    }
}
