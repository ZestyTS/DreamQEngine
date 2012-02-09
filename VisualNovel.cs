using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

using System.Data.SQLite;

namespace DreamQEngine
{
    public class VisualNovel
    {
        Scene mCurrentScene;
        String mName;
        public SQLiteConnection conn;

        public VisualNovel(string gameData)
        {
            //Create a new visual novel from a database file.

            //Get a connection to the gameData database
            conn = new SQLiteConnection(String.Format("Data Source={0}", gameData));
            conn.Open();
            SQLiteDataReader reader = new SQLiteCommand("Select * From Games;", conn).ExecuteReader();
            
            DataTable gameTable = new DataTable();
            gameTable.Load(reader);

            DataView gameView = new DataView(gameTable);

            if (gameView.Count > 0)
            {
                mCurrentScene = new Scene(Convert.ToInt32(gameView[0]["initialScene"]), conn);
                mName = gameView[0]["name"].ToString();
            }
        }

        public VisualNovel(string gameData, string savedGame)
        {
            //Load a saved visual novel            
        }

        public Scene getScene()
        {
            return mCurrentScene;
        }
    }

    //A simple object to represent a saved game state
    struct SavedGame
    {

    }
}
