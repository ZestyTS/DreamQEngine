using System;
using System.Collections.Generic;
using System.Text;

namespace DreamQEngine
{
    class Location
    {
        //The background image for this location
        protected string mImgPath;

        //This location's name
        protected string mName;

        public Location()
        {
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
