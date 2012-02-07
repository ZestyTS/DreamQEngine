using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine
{
    class Scene
    {
        //The location that this scene takes place
        protected Location mLocation;

        //The text intro describing the scene
        protected string mSetup;

        //The other characters involved in this scene
        protected Actor[] mActors;

        //The beginning dialogue in this scene
        protected Dialogue mStartingDialogue;

        public Scene():this(0)
        {
        }

        public Scene(int sceneRef)
        {
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

        public Actor[] actors
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
