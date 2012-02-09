using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SQLite;

namespace DreamQEngine
{
    public class Location
    {
        //The background image for this location
        protected string mImgPath;

        //This location's name
        protected string mName;

        public Location(int locationRef, SQLiteConnection conn)
        {
            SQLiteDataReader reader = new SQLiteCommand("Select * From Locations WHERE id = " + locationRef + ";", conn).ExecuteReader();

            DataTable locationtable = new DataTable();
            locationtable.Load(reader);

            DataView locationView = new DataView(locationtable);

            if (locationView.Count > 0)
            {
                mImgPath = locationView[0]["backgroundImage"].ToString();
                mName = locationView[0]["name"].ToString();
            }
        }

        public string imgPath {
            set { mImgPath = value; }
            get { return mImgPath; }
        }

        public string name
        {
            set { mName = value; }
            get { return mName; }
        }
    }
}
