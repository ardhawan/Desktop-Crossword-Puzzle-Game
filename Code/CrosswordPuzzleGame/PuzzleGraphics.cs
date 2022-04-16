using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrosswordPuzzleGame
{
    public partial class PuzzleGraphics : Form // need to change variables 
    {
        List<String> listofimages = new List<String>();
        string imagefile = Application.StartupPath + "\\Images";

        public PuzzleGraphics()
        {
            InitializeComponent();
            displayImage();
        }

        private void displayImage()
        {
            foreach (String imf in Directory.GetFiles(imagefile)) 
            {
                listofimages.Add(imf);
            }
            Random ran = new Random();
            int index = ran.Next(0, listofimages.Count()); 
            imagebox.Image = Image.FromFile(listofimages[index]);
            imagebox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
