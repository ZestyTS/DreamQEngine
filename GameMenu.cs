using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace DreamQs
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game("Sunshine");
            game.start();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
