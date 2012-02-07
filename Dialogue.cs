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
        protected Character mActor;

        //The choices presented to you at the end of the dialogue
        protected Option[] mChoices;

        public Dialogue()
        {
        }

        public Dialogue(int dialogueRef)
        {
        }

        public Option makeChoice(int choiceIndex)
        {
            return mChoices[0];
        }

        public List<Option> getDisplayChoices(Game game)
        {
            List<Option> returnList = new List<Option>();
            foreach (Option option in mChoices)
            {
                bool showOption = true;
                foreach (KeyValuePair<string, int> statReq in option.statReqs)
                {
                    if (game.player.stats[statReq.Key] < statReq.Value)
                    {
                        showOption = false;
                    }
                }
                foreach (KeyValuePair<string, bool> eventReq in option.eventReqs)
                {
                    if (!(game.events.ContainsKey(eventReq.Key) && game.events[eventReq.Key]))
                    {
                        showOption = false;
                    }
                }
                if (showOption)
                {
                    //Display this option
                    returnList.Add(option);
                }
            }
            return returnList;
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

        public Character actor
        {
            set { mActor = value; }
            get { return mActor; }
        }
    }
}
