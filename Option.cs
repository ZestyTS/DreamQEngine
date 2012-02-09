using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace DreamQEngine
{
    public class Option
    {
        //The text of this choice
        protected string mText;

        //The text displayed when showing this option to the player
        protected string mDisplayText;

        //The various event requirements needed to display this option
        protected Dictionary<string, bool> mEventReqs;

        //The various event checks that we need to save when taking this option
        protected Dictionary<string, bool> mEventChanges;

        //The amount various stats change when making this choice
        protected Dictionary<string, int> mStatChanges;

        //The various stat requirements needed to display this option
        protected Dictionary<string, int> mStatReqs;

        //The dialogue to move to after taking this option
        protected Outcome mOutcome;


        public Option()
        {
        }

        public Option(string text, string displayText, int outcomeType, int outcomeRef)
        {
            mText = text;
            mDisplayText = displayText;
            mOutcome = new Outcome(getOutcomeType(outcomeType), outcomeRef);
        }

        public string text
        {
            set { mText = value; }
            get { return mText; }
        }

        public Dictionary<string, int> statReqs
        {
            set { mStatReqs = value; }
            get { return mStatReqs; }
        }

        public string displayText
        {
            set { mDisplayText = value; }
            get { return mDisplayText; }
        }

        public Dictionary<string, int> statChanges
        {
            set { mStatChanges = value; }
            get { return mStatChanges; }
        }

        public Outcome outcome
        {
            set { mOutcome = value; }
            get { return mOutcome; }
        }

        public Dictionary<string, bool> eventReqs
        {
            set { mEventReqs = value; }
            get { return mEventReqs; }
        }

        public Dictionary<string, bool> eventChanges
        {
            set { mEventChanges = value; }
            get { return mEventChanges; }
        }

        private OutcomeType getOutcomeType(int type) {
            if(type == 0){
                return OutcomeType.dialogue;
            }
            else if (type == 1)
            {
                return OutcomeType.scene;
            }
            else if (type == 2)
            {
                return OutcomeType.fight;
            }
            else
            {
                return OutcomeType.gameEnd;
            }
        }
    }

    public enum OutcomeType { 
        dialogue, scene, fight, gameEnd
    }
    public struct Outcome
    {
        public OutcomeType type;
        public int reference;

        public Outcome(OutcomeType theType, int theRef)
        {
            type = theType;
            reference = theRef;
        }
    }
}
