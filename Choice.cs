using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace DreamQs
{
    class Choice
    {
        //The amount of popularity required to take this from negative to neutral
        //Below this number, the choice is perceived as negative
        protected int mNeutralPopReq;

        //The amount of popularity required to take this from neutral to positive
        //Below this number (but above mNeutralPop) the choice is perceived as neutral
        protected int mPosPopReq;

        //The minimum amount of charisma required to see this option
        protected int mCharMin;
        
        //The highest amount of charisma you can have before this option is no longer displayed
        protected int mCharMax;

        //The text of this choice
        protected string mText;

        //The text displayed when showing this option to the player
        protected string mDisplayText;

        //The amount various stats change based on these choices
        protected StatChange[] mStatChanges;

        //The dialogue to move to if this option is taken positively
        protected int mPosOutcomeRef;

        //The dialogue to move to if this option is taken negatively
        protected int mNegOutcomeRef;

        //The dialogue to move to if this option is taken neutrally
        protected int mNeutralOutcomeRef;


        public Choice()
        {
        }

        public int neutralPopReq
        {
            set { mNeutralPopReq = value; }
            get { return mNeutralPopReq; }
        }

        public int posPopReq
        {
            set { mPosPopReq = value; }
            get { return mPosPopReq; }
        }

        public int charMin
        {
            set { mCharMin = value; }
            get { return mCharMin; }
        }

        public int charMax
        {
            set { mCharMax = value; }
            get { return mCharMax; }
        }

        public string text
        {
            set { mText = value; }
            get { return mText; }
        }

        public string displayText
        {
            set { mDisplayText = value; }
            get { return mDisplayText; }
        }

        public StatChange[] statChanges
        {
            set { mStatChanges = value; }
            get { return mStatChanges; }
        }

        public int posOutcomeRef
        {
            set { mPosOutcomeRef = value; }
            get { return mPosOutcomeRef; }
        }

        public int negOutcomeRef
        {
            set { mNegOutcomeRef = value; }
            get { return mNegOutcomeRef; }
        }

        public int neutralOutcomeRef
        {
            set { mNeutralOutcomeRef = value; }
            get { return mNeutralOutcomeRef; }
        }
    }
    class StatChange
    {
        //The stat that will change
        protected Stat mToChange;

        //The amount the stat will change
        protected int mChangeAmount;

        //The choice perception requirements for the change to take affect
        protected int mPerceptionReq;

        public StatChange(Stat toChange, int changeAmount, int perceptionReq)
        {
            mToChange = toChange;
            mChangeAmount = changeAmount;
            mPerceptionReq = perceptionReq;
        }

        public Stat applyChange(int perceptionVal)
        {
            //Add changeAmount to the stat, and return
            mToChange.value += mChangeAmount;
            return mToChange;
        }
    }
}
