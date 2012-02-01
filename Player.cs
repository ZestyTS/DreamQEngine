using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SQLite;
using System.Data;

namespace DreamQs
{
    class Player : Character
    {

        //This stat determines how people react to the choices you make,
        //the higher it is, the more likely people react positively to
        //what you say. It also determines the amount of change that
        //happens in the level of interest shown by the love interests
        protected int mPopularity;

        //This stat affects your popularity, as well as how easily you 
        //you can defeat your opponents in battle
        protected int mStrength;
        
        //How to do grades, maybe per-class, no idea.

        //With a higher charisma comes more choices in responding to dialogue
        //options, there are also different choices for those with high charisma
        protected int mCharisma;


        //This stat determines how high your grades are, this also determines
        //your abilities with magic
        protected int mIntelligence;

        public Player()
        {
        }
    }
}
