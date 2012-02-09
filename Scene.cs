using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SQLite;

namespace DreamQEngine
{
    public class Scene
    {
        //The location that this scene takes place
        protected Location mLocation;

        //The text intro describing the scene
        protected string mSetup;

        //The other characters involved in this scene
        protected Actor[] mActors;

        //The beginning dialogue in this scene
        protected Dialogue mStartingDialogue;

        public Scene()
        {
        }

        public Scene(int sceneRef, SQLiteConnection conn)
        {
            SQLiteDataReader reader = new SQLiteCommand("Select * From Scenes WHERE id = "+sceneRef+";", conn).ExecuteReader();

            DataTable sceneTable = new DataTable();
            sceneTable.Load(reader);

            DataView sceneView = new DataView(sceneTable);

            if (sceneView.Count > 0)
            {
                mLocation = new Location(Convert.ToInt32(sceneView[0]["locationId"]), conn);
                mStartingDialogue = new Dialogue(Convert.ToInt32(sceneView[0]["initialDialogueId"]), conn);
                mSetup = sceneView[0]["setupText"].ToString();

                reader = new SQLiteCommand("Select * From Actors_Scenes WHERE sceneId = " + sceneRef + ";", conn).ExecuteReader();
                DataTable actorsTable = new DataTable();
                actorsTable.Load(reader);

                DataView actorsView = new DataView(actorsTable);

                mActors = new Actor[actorsView.Count];
                for (int i = 0; i < actorsView.Count; i++)
                {
                    mActors[i] = new Actor(Convert.ToInt32(actorsView[i]["actorId"]), conn);
                }
            }
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
