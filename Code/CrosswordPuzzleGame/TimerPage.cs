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
    public partial class TimerPage : Form
    {
        public TimerPage()
        {
            InitializeComponent();
        }

        private void easytimer_Click(object sender, EventArgs e)
        {
            CrosswordPuzzle level1 = new CrosswordPuzzle(0);
            this.Hide();
            string message = "Welcome to Level 1 of the crossword game!!!";
            string title = "Level 1";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, button);
            level1.Show();
        }

        private void hardtimer_Click(object sender, EventArgs e)
        {
            CrosswordPuzzle level1 = new CrosswordPuzzle(1);
            this.Hide();
            string message = "Welcome to Level 1 of the crossword game!!!";
            string title = "Level 1";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, button);
            level1.Show();
        }

        private void backpage_Click(object sender, EventArgs e)
        {
            StartingPage sp = new StartingPage();
            this.Hide();
            sp.Show();
        }
    }
}
