using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace DreamQs
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

        public void beginScene(GameForm gameForm)
        {
            gameForm.Controls["lblDialogue"].Text = "Scene Start!";
            gameForm.Controls["pbBackground"].BackColor = System.Drawing.Color.AliceBlue;
            //Get location information and set form stuff
            //Show scene setup text

            //Show initial dialogue

            //Wait for choice

            //Do consequences of choice

            //Show next dialogue
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
