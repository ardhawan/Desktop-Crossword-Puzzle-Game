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
    public partial class CustomSetting : Form
    {
        string customfilelocation = Application.StartupPath + "\\CustomPuzzleLevel";
        int filenumber;
        int cl;
        int ct;
        int customtemp = 0;
        public CustomSetting()
        {
            InitializeComponent();
        }

        private void addcustom_Click(object sender, EventArgs e)
        {
            if (customtime.Text != "" && customlevel.Text != "" && (hourtime.Checked == true || minutetime.Checked == true))
            {
                calculateLevelInformation();
            }
            else
            {
                string message = "The information entered is incomplete";
                string title = "Incomplete Information";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                customtime.Text = "";
                customlevel.Text = "";
                minutetime.Checked = false;
                hourtime.Checked = false;
            }


            if(customtemp == 2)
            {
                string message = "Thank you for the settings";
                string title = "Thank you";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void calculateLevelInformation()
        {
            string[] numberofcustomfiles = Directory.GetFiles(customfilelocation);
            filenumber = numberofcustomfiles.Count();
            bool leveltest = Int32.TryParse(customlevel.Text, out cl); 
            if(!leveltest)
            {
                string message = "The file number cannot be found";
                string title = "Wrong File Number";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                customtime.Text = "";
                customlevel.Text = "";
                minutetime.Checked = false;
                hourtime.Checked = false;
            }
            else if (cl == 0)
            {
                string message = "There is no level added";
                string title = "Wrong File Number";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                customtime.Text = "";
                customlevel.Text = "";
                minutetime.Checked = false;
                hourtime.Checked = false;
            }
            else if(cl > filenumber)
            {
                string message = "The file number entered is out of range";
                string title = "Wrong File Number";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                customtime.Text = "";
                customlevel.Text = "";
                minutetime.Checked = false;
                hourtime.Checked = false;
            }
            else
            {
                customtemp = customtemp + 1;
                calculateTimeInformation();
            }

        }
        public void calculateTimeInformation()
        {
            bool customtest = Int32.TryParse(customtime.Text, out ct); 
            if (!customtest)
            {
                string message = "Please follow the correct time format";
                string title = "Wrong Time Format";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                customtemp = customtemp - 1;
                customtime.Text = "";
                customlevel.Text = "";
                minutetime.Checked = false;
                hourtime.Checked = false;
            }
            else if (minutetime.Checked == true)
            {
                ct = Int32.Parse(customtime.Text);
                customtime.Text = ct.ToString();
                customtemp = customtemp + 1;
            }
            else if(hourtime.Checked == true)
            {
                ct = Int32.Parse(customtime.Text);
                ct = (ct*60);
                customtime.Text = ct.ToString();
                customtemp = customtemp + 1;
            }
        }
        public string CustomTime
        {
            get { return customtime.Text; }
        }

        public string CustomLevel
        {
            get { return customlevel.Text; }
        }

        private void customlevel_Click(object sender, EventArgs e)
        {
            if (timelbl.Visible == true)
            {
                timelbl.Visible = false;
            }
            levellbl.Visible = true;
        }

        private void customtime_Click(object sender, EventArgs e)
        {
            if(levellbl.Visible == true)
            {
                levellbl.Visible = false;
            }
            timelbl.Visible = true;
        }

        private void customlevel_TextChanged(object sender, EventArgs e)
        {
            levellbl.Visible = true;
        }
    }
}
