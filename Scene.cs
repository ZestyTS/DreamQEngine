using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace DreamQEngine
{
    class Scene
    {
        //The location that this scene takes place
        protected Location mLocation;

        //The text intro describing the scene
        protected string mSetup;

        //The other characters involved in this scene
        protected Character[] mActors;

        //The beginning dialogue in this scene
        protected Dialogue mStartingDialogue;

        public Scene():this(0)
        {
        }

        public Scene(int sceneRef)
        {
        }

        public Outcome startFight(Player player, Enemy enemy)
        {
            //Do fighting things!
            return new Outcome(OutcomeType.scene, 0);
        }

        public Scene doScene(GameForm gameForm)
        {

            gameForm.Controls["pbBackground"].BackgroundImage = System.Drawing.Image.FromFile(mLocation.imgPath);
            //Get location information and set form stuff
            
            //Show scene setup text
            gameForm.Controls["lblDialogue"].Text = mSetup;

            //Wait for button press

            //Show initial dialogue
            string initialDialogue = mStartingDialogue.text;

            //Give options to user
            List<Option> choices = mStartingDialogue.getDisplayChoices(gameForm.gameObject);

            //wait for user's choice
            int pickOption = 0;

            //Find outcome of choice
            Outcome choiceOutcome = choices[pickOption].pickOption(gameForm.gameObject);

            while (choiceOutcome.type != OutcomeType.scene)
            {
                //Keep doing stuff!
                if (choiceOutcome.type == OutcomeType.dialogue)
                {
                    //Do dialogue
                    Dialogue nextDialogue = new Dialogue(choiceOutcome.reference);

                    //Give options to user
                    List<Option> nextChoices = nextDialogue.getDisplayChoices(gameForm.gameObject);

                    //wait for user's choice
                    int nextOption = 0;

                    //Set the outcome of the choice!
                    choiceOutcome = choices[nextOption].pickOption(gameForm.gameObject);
                }
                else if (choiceOutcome.type == OutcomeType.fight)
                {
                    //Do fight!
                    choiceOutcome = startFight(gameForm.gameObject.player, new Enemy(choiceOutcome.reference));
                }
                else
                {
                    //broken
                    return null;
                }
            }

            return new Scene(choiceOutcome.reference);
        }

        public Location location
        {
            set { mLocation = value; }
            get { return mLocation; }
        }

        public Dialogue startingDialogue
        {
            set { mStartingDialogue = value; }
            get { return mStartingDialogue; }
        }

        public Character[] actors
        {
            set { mActors = value; }
            get { return mActors; }
        }

        public string setup
        {
            set { mSetup = value; }
            get { return mSetup; }
        }
    }
}
