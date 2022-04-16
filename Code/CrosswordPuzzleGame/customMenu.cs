
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
    public partial class CustomMenu : Form
    {
        public CustomMenu()
        {
            InitializeComponent();
        }

        private void addcustom_Click(object sender, EventArgs e)
        {
            CustomPuzzleInformation cpi = new CustomPuzzleInformation();
            this.Hide();
            string message = "Please enter the following information";
            string title = "Enter The Information";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button);
            cpi.Show();
        }

        private void playcustom_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrosswordPuzzle cp = new CrosswordPuzzle(2);
            string message = "Welcome to Custom Level!!!";
            string title = "Custom Level";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, button);
            cp.Show();
        }

        private void backpage_Click(object sender, EventArgs e)
        {
            StartingPage sp = new StartingPage();
            this.Hide();
            sp.Show();
        }
    }
}
