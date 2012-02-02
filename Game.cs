using System;
using System.Collections.Generic;
using System.Text;

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
            currentScene.beginScene(gameForm);
        }
    }

    //A simple object to represent a saved game state
    struct SavedGame
    {
        public string playerName;
        public Stat[] playerStats;
        //Grades
        public int[] loveInterestLevels;

        public int sceneNum;

        public SavedGame(string name, Stat[] stats, int[]loveLevels, int scene)
        {
            playerName = name;
            sceneNum = scene;
            playerStats = stats; 
            loveInterestLevels = loveLevels;
        }
    }
}
