using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrosswordPuzzleGame
{
    public partial class CustomPuzzleInformation : Form
    {
        String customfilelocation;
        int filenumber;
        int xn, yn,cn;
        int customtemp = 0;
        int answerlength, totaldownlength, totalacrosslength;
        List<int> downlist = new List<int>();
        List<int> acrosslist = new List<int>();
        public CustomPuzzleInformation()
        {
            InitializeComponent();
        }

        private void addinformation_Click(object sender, EventArgs e)
        {
            if (xnumber.Text != "" && ynumber.Text != "" && direction.Text != "" && cluenumber.Text != "" && answer.Text != "" && clue.Text != "")
            {
                calculateXInformation();
            }
            else
            {
                string message = "The information entered is incomplete"; 
                string title = "Incomplete Information";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }


            if (customtemp != 6)
            {
                customtemp = 0;
            }
            else if(customtemp == 6)
            {
                File.AppendAllText(customfilelocation, xnumber.Text + "|" + ynumber.Text + "|" + direction.Text + "|" + cluenumber.Text + "|" + answer.Text + "|" + clue.Text + Environment.NewLine);
                string message = "Thank you for the information";
                string title = "Thank you";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
                customtemp = 0;
            }
        }
        private void AddEncryption()
        {
            DESCryptoServiceProvider puzzledesprovider = new DESCryptoServiceProvider();
            puzzledesprovider.Key = ASCIIEncoding.ASCII.GetBytes("7f1309cb");
            puzzledesprovider.IV = ASCIIEncoding.ASCII.GetBytes("7f1309cb");
            ICryptoTransform puzzlecryptotransform = puzzledesprovider.CreateEncryptor(puzzledesprovider.Key, puzzledesprovider.IV);
            FileStream encryptfilestream = new FileStream(customfilelocation, FileMode.Open, FileAccess.Read);
            FileStream encryptedpuzzlefile = new FileStream(Application.StartupPath + "\\CustomPuzzleLevel\\encryptcustomset" + filenumber + ".txt", FileMode.Create, FileAccess.Write);
            CryptoStream puzzlecryptostream = new CryptoStream(encryptedpuzzlefile, puzzlecryptotransform, CryptoStreamMode.Write);
            byte[] puzzleinput = new byte[encryptfilestream.Length];
            encryptfilestream.Read(puzzleinput, 0, puzzleinput.Length);
            puzzlecryptostream.Write(puzzleinput, 0, puzzleinput.Length);
            puzzlecryptostream.Close();
            encryptfilestream.Close();
            encryptedpuzzlefile.Close();
            File.Delete(customfilelocation);
        }
        private void CustomPuzzleInformation_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Application.StartupPath + "\\CustomPuzzleLevel");
            string [] numberofcustomfiles = Directory.GetFiles(Application.StartupPath + "\\CustomPuzzleLevel");
            filenumber = numberofcustomfiles.Count();
            filenumber = filenumber + 1;
            FileStream fs = File.Create(Application.StartupPath + "\\CustomPuzzleLevel\\customset" + filenumber + ".txt");
            fs.Close();
            customfilelocation = Application.StartupPath + "\\CustomPuzzleLevel\\customset" + filenumber + ".txt";
            File.AppendAllText(customfilelocation, "x|y|direction|number|word|clue" + Environment.NewLine);
        }
        private void calculateXInformation()
        {
            bool xtest = Int32.TryParse(xnumber.Text, out xn); 
            if (!xtest)
            {
                string message = "The x-coordinate is wrong"; 
                string title = "Wrong Format";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
            else if(xn >= 0 && xn <= 24) 
            {
                customtemp = customtemp + 1;
                calcualteYInformation();
            }
            else
            {
                string message = "The x-coordinate entered is out of range"; 
                string title = "Wrong Format";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
        }
        private void calcualteYInformation()
        {
            bool ytest= Int32.TryParse(ynumber.Text, out yn); 
            if (!ytest)
            {
                string message = "The y-coordinate is wrong";
                string title = "Wrong Format";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
            else if (yn >= 0 && yn <= 17) 
            {
               customtemp = customtemp + 1;
                calculateDirectionInformation();
            }
            else
            {
                string message = "The y-coordinate entered is out of range"; 
                string title = "Wrong Format";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
        }
        private void calculateDirectionInformation()
        {
            if(direction.Text == "down")
            {
                customtemp = customtemp + 1;
                calculateClueNumberInformation();
            }
            else if(direction.Text == "across")
            {
                customtemp = customtemp + 1;
                calculateClueNumberInformation();
            }
            else
            {
                string message = "The direction entered is invalid"; 
                string title = "Invalid Direction";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
        }

        private void customrulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "1.x-coordiante range is from 0 to 24.\n2.y-coordinate range is from 0 to 17.\n3.Direction is either across or down.\n4.The clue number can only be used once in both down and \t\t   across.\n5.There should be no blank spaces in between the answers.\n6.Clue cannot contian more than 200 characters.";
            string title = "Custom Rules";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button);
        }

        private void calculateClueNumberInformation() 
        {
            bool cluetest = Int32.TryParse(cluenumber.Text, out cn); 
            if (!cluetest)
            {
                string message = "The clue number is wrong";
                string title = "Wrong Format";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
            else if (direction.Text == "down")
            {
                if(downlist.Contains(cn))
                {
                    string message = "The clue number is already assigned"; 
                    string title = "Wrong Format";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, button);
                    xnumber.Text = "";
                    ynumber.Text = "";
                    direction.Text = "";
                    cluenumber.Text = "";
                    answer.Text = "";
                    clue.Text = "";
                }
                else
                {
                    customtemp = customtemp + 1;
                    downlist.Add(cn);
                    calculateAnswerInformation();
                }
            }
            else if (direction.Text == "across")
            {
                if (acrosslist.Contains(cn))
                {
                    string message = "The clue number is already assigned"; 
                    string title = "Wrong Format";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, button);
                    xnumber.Text = "";
                    ynumber.Text = "";
                    direction.Text = "";
                    cluenumber.Text = "";
                    answer.Text = "";
                    clue.Text = "";
                }
                else
                {
                    customtemp = customtemp + 1;
                    acrosslist.Add(cn);
                    calculateAnswerInformation();
                }
            }
        }
        private void calculateAnswerInformation()
        {
            answerlength = answer.Text.Count();
            totaldownlength = yn + answerlength - 1;
            totalacrosslength = xn + answerlength - 1;
            if (answer.Text.Contains(" "))
            {
                string message = "Please avoid blank spaces between the answer";
                string title = "Invalid Format"; 
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
            else if (direction.Text == "down" && (totaldownlength >= 0 && totaldownlength <= 17))
            {
                customtemp = customtemp + 1;
                calculateClueInformation();
            }
            else if (direction.Text == "across" && (totalacrosslength >= 0 && totalacrosslength <= 24))
            {
                customtemp = customtemp + 1;
                calculateClueInformation();
            }
            else
            {
                string message = "The answer is out of range"; 
                string title = "Out of range";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
        }
        private void calculateClueInformation()
        {
            if(clue.Text.Length <= 200)
            {
                customtemp = customtemp + 1;
            }
            else
            {
                string message = "The clue is out of range"; 
                string title = "Out of range";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
                xnumber.Text = "";
                ynumber.Text = "";
                direction.Text = "";
                cluenumber.Text = "";
                answer.Text = "";
                clue.Text = "";
            }
        }
        private void backpage_Click(object sender, EventArgs e) 
        {
            if(File.ReadLines(customfilelocation).Count() == 1)
            {
                File.Delete(Application.StartupPath + "\\CustomPuzzleLevel\\customset" + filenumber + ".txt");
                CustomMenu cm = new CustomMenu();
                this.Hide();
                string message = "The puzzle set is empty";
                string title = "Empty File";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
                cm.Show();
            }
            else
            {
                downlist.Clear();
                acrosslist.Clear();
                AddEncryption();
                CustomMenu cm = new CustomMenu();
                this.Hide();
                string message = "Thank you for creating the puzzle set";
                string title = "Thank you";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
                cm.Show();
            }
        }
    }
}
