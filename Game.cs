using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SQLite;
using System.Data;

namespace DreamQs
{
    class Game
    {
        public Player player;
        public Scene currentScene;

        public Game()
        {
            //Create a new game from nothing.
        }

        public Game(string playerName)
        {
            player = new Player(playerName);
            currentScene = new Scene();
        }

        public Game(SavedGame gamefile)
        {
            //Load a game from a saved game file
            player = new Player(gamefile);
            currentScene = new Scene(gamefile.sceneNum);
        }

        public void start(){
            GameForm gameForm = new GameForm(this);
        }
    }

    //A simple object to represent a saved game state
    struct SavedGame
    {
        public string playerName;
        public int popularity, strength, charisma, intelligence, sceneNum;
        //Grades
        public int[] loveInterestLevels;

        public SavedGame(string name, int pop, int str, int chr, int intel, int scene, int[]loveLevels)
        {
            playerName = name;
            popularity = pop;
            strength = str;
            charisma = chr;
            intelligence = intel;
            sceneNum = scene;
            loveInterestLevels = loveLevels;
        }
    }
}
