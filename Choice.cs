using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SQLite;
using System.Data;

namespace DreamQs
{
    class Choice
    {
        //The amount of popularity required to take this from negative to neutral
        //Below this number, the choice is perceived as negative
        protected int mNeutralPop;

        //The amount of popularity required to take this from neutral to positive
        //Below this number (but above mNeutralPop) the choice is perceived as neutral
        protected int mPosPop;

        //The minimum amount of charisma required to see this option
        protected int mCharMin;
        
        //The highest amount of charisma you can have before this option is no longer displayed
        protected int mCharMax;

        //The text of this choice
        protected string mText;

        //The amount your popularity changes if you take this option (multiply by -1 if negative, 0 if neutral)
        protected int mPopChange;

        //The dialogue to move to if this option is taken positively
        protected int mPosOutcomeRef;

        //The dialogue to move to if this option is taken negatively
        protected int mNegOutcomeRef;

        //The dialogue to move to if this option is taken neutrally
        protected int mNeutralOutcomeRef;


        public Choice()
        {
        }
    }
}
