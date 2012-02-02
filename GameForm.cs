using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Data.SQLite;

namespace DreamQs
{
    partial class GameForm : Form
    {
        protected Game gameObject;

        public GameForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public GameForm(Game game)
        {
            //Set up initial values based on the passed in game.
            gameObject = game;

            //lblDialogue.Text = gameObject.currentScene.startingDialogue.text;

            //Set bg image

            //Set NPC image

            //Show choices

            this.Show();

            InitializeComponent();
        }
    }
}
