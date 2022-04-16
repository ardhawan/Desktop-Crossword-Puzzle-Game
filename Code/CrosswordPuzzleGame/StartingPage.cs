using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrosswordPuzzleGame
{
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();
        }
        private void customgame_Click(object sender, EventArgs e)
        {
            CustomMenu cm = new CustomMenu();
            this.Hide();
            string message = "Please choose either play custom puzzle or add custom puzzle?";
            string title = "Game Type Selection";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button);
            cm.Show();
        }
        private void newgame_Click(object sender, EventArgs e) 
        {
            TimerPage selectTimer = new TimerPage();
            this.Hide();
            string message = "Please choose either easy or hard timer?"; 
            string title = "Timer Selection";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button);
            selectTimer.Show();
        }
        private void endgame_Click(object sender, EventArgs e)
        {
            string message = "Thank you for playing the game";
            string title = "Thank you";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button);
            this.Close();
            Environment.Exit(0);
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "1.User has to choose custom game or play normal game.\n2.In custom game, the user has to choose to add custom level or to play    custom game.\n3. In regular game, the user has to choose easy timer or hard timer.\n4.In easy timer the user has to play 10 levels in 60 minutes.\n5.In hard timer the user has to play 15 levels in 40 minutes.";
            string title = "Rules";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button);
        }
    }
}
