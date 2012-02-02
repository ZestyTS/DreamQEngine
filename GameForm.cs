using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace DreamQs
{
    partial class GameForm : Form
    {
        protected Game gameObject;

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(Game game)
        {
            //this.StartPosition = FormStartPosition.Manual;
            //Set up initial values based on the passed in game.
            gameObject = game;

            //lblDialogue.Text = gameObject.currentScene.startingDialogue.text;

            //Set bg image

            //Set NPC image

            //Show choices

            this.Show();

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
        }
    }
}
