using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SQLite;

namespace DreamQEngine
{
    public class Actor
    {
        //This character's name
        protected string mName;

        public Actor(string name)
        {
            mName = name;
        }

        public Actor(int actorRef, SQLiteConnection conn)
        {
            SQLiteDataReader reader = new SQLiteCommand("Select * From Actors WHERE id = " + actorRef + ";", conn).ExecuteReader();

            DataTable actorTable = new DataTable();
            actorTable.Load(reader);

            DataView actorView = new DataView(actorTable);

            if (actorView.Count > 0)
            {
                mName = actorView[0]["name"].ToString();
            }
        }

        //Getters and setters for character name
        public string name
        {
            set { mName = value; }
            get { return mName; }
        }
    }
}
