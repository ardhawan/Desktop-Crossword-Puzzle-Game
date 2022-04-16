using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Media;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace CrosswordPuzzleGame
{
    public partial class CrosswordPuzzle : Form
    {
        CluesTable listofclues = new CluesTable();
        List<filecells> fc = new List<filecells>();
        int numberofgreencells = 0;
        int numberofwhitecells = 0;
        int value, durationleft, minutes, seconds;
        int clocktest = 0;
        Audio playaudio = new Audio();
        string manualtime, manuallevel;
        int mt, ml;
        List<string> listoffiles = new List<string>();
        string filelocation = Application.StartupPath + "\\Puzzles";
        string customfilename;
        string SoundLocation = Application.StartupPath + "\\Sound\\MusicInGame.wav";

        public CrosswordPuzzle(int value)
        {
            this.value = value;  
            if(value == 0)
            {
                setEasyTimer();
            }
            else if(value == 1)
            {
                setHardTimer();
            }
            else if(value == 2)
            {
                setCustomGame();
            }
            cluesAccess(); 
            InitializeComponent();
        }

        private void setEasyTimer()
        {
            string[] puzzlefiles = Directory.GetFiles(filelocation);
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                int index = ran.Next(0, puzzlefiles.Count()); 
                listoffiles.Add(puzzlefiles[index]);
            }
            FileStream fs = File.Create(Application.StartupPath + "\\Puzzles\\decryptedfile.txt");
            fs.Close();
            customfilename = Application.StartupPath + "\\Puzzles\\decryptedfile.txt";
            decryptPuzzleFile();
        }

        private void setHardTimer()
        {
            string[] puzzlefiles = Directory.GetFiles(filelocation);
            Random ran = new Random();
            for (int i = 0; i < 15; i++)
            {
                int index = ran.Next(0, puzzlefiles.Count()); 
                listoffiles.Add(puzzlefiles[index]);
            }
            FileStream fs = File.Create(Application.StartupPath + "\\Puzzles\\decryptedfile.txt");
            fs.Close();
            customfilename = Application.StartupPath + "\\Puzzles\\decryptedfile.txt";
            decryptPuzzleFile();
        }

        private void setCustomGame() 
        {
            CustomSetting cs = new CustomSetting(); 
            if (cs.ShowDialog() == DialogResult.OK)
            {
                manuallevel = cs.CustomLevel;
                manualtime = cs.CustomTime;
                cs.Hide();
            }
            mt = Int32.Parse(manualtime);
            ml = Int32.Parse(manuallevel);
            filelocation = Application.StartupPath + "\\CustomPuzzleLevel";
            string[] puzzlefiles = Directory.GetFiles(filelocation);
            Random ran = new Random();
            for (int i = 0; i < ml; i++)
            {
                int index = ran.Next(0, puzzlefiles.Count());
                listoffiles.Add(puzzlefiles[index]);
            }
            FileStream fs = File.Create(Application.StartupPath + "\\CustomPuzzleLevel\\decryptedfile.txt");
            fs.Close();
            customfilename = Application.StartupPath + "\\CustomPuzzleLevel\\decryptedfile.txt";
            decryptPuzzleFile();
        }
        public void cluesAccess()
        {
            String cellline = "";
            using (StreamReader cellreader = new StreamReader(customfilename))
            {
                cellline = cellreader.ReadLine();
                while ((cellline = cellreader.ReadLine()) != null)
                {
                    String[] l = cellline.Split('|');
                    fc.Add(new filecells(Int32.Parse(l[0]), Int32.Parse(l[1]), l[2], l[3], l[4], l[5]));
                    listofclues.ClueList.Rows.Add(new String[] { l[3], l[2], l[5] });
                }
            }
        }
        private void decryptPuzzleFile()
        {
            DESCryptoServiceProvider puzzledesprovider = new DESCryptoServiceProvider();
            puzzledesprovider.Key = ASCIIEncoding.ASCII.GetBytes("7f1309cb");
            puzzledesprovider.IV = ASCIIEncoding.ASCII.GetBytes("7f1309cb"); 
            FileStream decryptedpuzzlefile = new FileStream(listoffiles[0], FileMode.Open, FileAccess.Read);
            ICryptoTransform puzzlecryptotransform = puzzledesprovider.CreateDecryptor(puzzledesprovider.Key, puzzledesprovider.Key);
            CryptoStream puzzlecryptostream = new CryptoStream(decryptedpuzzlefile, puzzlecryptotransform, CryptoStreamMode.Read);
            StreamReader puzzlestreamreader = new StreamReader(puzzlecryptostream);
            StreamWriter puzzlestreamwriter = new StreamWriter(customfilename);
            puzzlestreamwriter.Write(puzzlestreamreader.ReadToEnd());
            puzzlecryptostream.Close();
            puzzlestreamreader.Close();
            puzzlestreamwriter.Close();
        }
        private void CrosswordPuzzle_Load(object sender, EventArgs e)
        {
            InitializeCrosswordBoard();
            listofclues.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y);
            listofclues.Show();
            setClock();
            playaudio.Play(SoundLocation, AudioPlayMode.BackgroundLoop);
        }

        private void setClock() 
        { 
            if (value == 0)
            {
                timerlbl.Text = "60 MINUTES : 00 SECONDS";
                this.durationleft = 3600;
                this.minutes = 60 - 1;
            }
            else if (value == 1)
            {
                timerlbl.Text = "40 MINUTES : 00 SECONDS";
                this.durationleft = 2400;
                this.minutes = 40 - 1;
            }
            else if (value == 2)
            {
                timerlbl.Text = mt + " MINUTES : 00 SECONDS";
                this.durationleft = (mt*60);
                this.minutes = mt -1;
            }
        }

        private void checksound_CheckedChanged(object sender, EventArgs e)
        {
            if(checksound.Checked == false)
            {
                playaudio.Stop();
            }
            else
            {
                playaudio.Play(SoundLocation, AudioPlayMode.BackgroundLoop);
            }
        }

        private void InitializeCrosswordBoard()
        {
            crosswordgrid.BackgroundColor = Color.Black;
            crosswordgrid.DefaultCellStyle.BackColor = Color.Black;
            crosswordgrid.DefaultCellStyle.Font = new Font("Tahoma", 14);

            for (int i = 0; i < 18; i++) 
            {
                crosswordgrid.Rows.Add();
            }

            foreach (DataGridViewColumn col in crosswordgrid.Columns)
            {
                col.Width = crosswordgrid.Width / crosswordgrid.Columns.Count;
            }

            foreach (DataGridViewRow rw in crosswordgrid.Rows)
            {
                rw.Height = crosswordgrid.Height / crosswordgrid.Rows.Count;
            }

            for (int rw = 0; rw < crosswordgrid.Rows.Count; rw++)
            {
                for (int col = 0; col < crosswordgrid.Columns.Count; col++)
                {
                    crosswordgrid[col, rw].ReadOnly = true;
                }
            }

            foreach (filecells f in fc)
            {
                int inicol = f.X;
                int inirow = f.Y;
                char[] celltext = f.answer.ToCharArray(); 

                for (int k = 0; k < celltext.Length; k++)
                {
                    if (f.puzzledirection == "across")
                    {
                        structureCell(inirow, inicol + k, celltext[k]);
                    }
                    if (f.puzzledirection == "down")
                    {
                        structureCell(inirow + k, inicol, celltext[k]);
                    }
                }
            }

            for (int rw = 0; rw < crosswordgrid.Rows.Count; rw++)
            {
                for (int col = 0; col < crosswordgrid.Columns.Count; col++)
                {
                    if (crosswordgrid[col, rw].Style.BackColor == Color.White)
                    {
                        numberofwhitecells = numberofwhitecells + 1;
                    }
                }
            }
        }

        private void structureCell(int rw, int col, char text)
        {
            DataGridViewCell box = crosswordgrid[col, rw];
            box.Style.BackColor = Color.White;
            box.ReadOnly = false;
            box.Style.SelectionBackColor = Color.Blue;
            box.Tag = text;
        }

        private void CrosswordBoard_CellValueChanged(object sender, DataGridViewCellEventArgs ae)
        {
            try
            {
                if (crosswordgrid[ae.ColumnIndex, ae.RowIndex].Value.ToString().Equals(crosswordgrid[ae.ColumnIndex, ae.RowIndex].Tag.ToString())) // the string and char check
                {
                    numberofgreencells = numberofgreencells + 1;
                    crosswordgrid[ae.ColumnIndex, ae.RowIndex].Style.ForeColor = Color.DarkGreen;
                }
                else
                {
                    crosswordgrid[ae.ColumnIndex, ae.RowIndex].Style.ForeColor = Color.Red;
                }

                if (numberofwhitecells == numberofgreencells)
                {
                    listoffiles.RemoveAt(0);
                    if (listoffiles.Count != 0)
                    {
                        crosswordgrid.Rows.Clear();
                        listofclues.ClueList.Rows.Clear();
                        fc.Clear();
                        clock.Enabled = false;
                        PuzzleGraphics transitionimage = new PuzzleGraphics();
                        if (transitionimage.ShowDialog() == DialogResult.OK)
                        {
                            transitionimage.Hide();
                        }
                        numberofwhitecells = 0;
                        numberofgreencells = 0;
                        decryptPuzzleFile();
                        cluesAccess();
                        clock.Enabled = true;
                        InitializeCrosswordBoard();
                    }
                    else
                    {
                        playaudio.Stop();
                        clock.Enabled = false;
                        File.Delete(customfilename);
                        StartingPage sp = new StartingPage();
                        this.Hide();
                        listofclues.Hide();
                        string message = "Congratulations for completing the game";
                        string title = "Game Finish";
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, button);
                        sp.Show();
                    }
                }
            }
            catch
            {
                
            }
        }

        private void CrosswordBoard_CellPainting(object sender, DataGridViewCellPaintingEventArgs ae)
        {
            String boxnumber = "";
            if (fc.Any(cell => (boxnumber = cell.number) != "" && cell.X == ae.ColumnIndex && cell.Y == ae.RowIndex))
            {
                Rectangle rec = new Rectangle(ae.CellBounds.X, ae.CellBounds.Y, ae.CellBounds.Width, ae.CellBounds.Height);
                ae.Graphics.FillRectangle(Brushes.White, rec);
                Font ft = new Font(ae.CellStyle.Font.FontFamily, 10); 
                ae.Graphics.DrawString(boxnumber, ft, Brushes.Black, rec);
                ae.PaintContent(ae.ClipBounds);
                ae.Handled = true;
            }
        }

        private void clock_Tick(object sender, EventArgs e) 
        {
            if(durationleft > 0)
            {
                durationleft--;
                clocktest++;
                seconds = durationleft % 60;
                if (durationleft == 0)
                {
                    playaudio.Stop();
                    clock.Enabled = false;
                    File.Delete(customfilename);
                    StartingPage sp = new StartingPage(); 
                    this.Hide();
                    listofclues.Hide();
                    string message = "Sorry, you have not completed the game in time";
                    string title = "Game Over";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, button);
                    sp.Show();
                }
                else if (clocktest == 60)
                {
                    timerlbl.Text = minutes.ToString() + " MINUTES : 00 SECONDS"; 
                    minutes = minutes - 1;
                    clocktest = 0;
                }
                else if (minutes == 0) 
                {
                    timerlbl.Text = seconds.ToString() + " SECONDS";
                }
                else if (seconds < 10)
                {
                    timerlbl.Text = minutes.ToString() + " MINUTES : 0" + seconds.ToString() + " SECONDS";
                }
                else if (seconds >= 10)
                {
                    timerlbl.Text = minutes.ToString() + " MINUTES : " + seconds.ToString() + " SECONDS";
                }
            } 
        }
    }

    public class filecells
    {
        public int X;
        public int Y;
        public String puzzledirection;
        public String number;
        public String answer;
        public String puzzleclue;

        public filecells(int x, int y, String pd, String n, String ans, String pc)
        {
            this.X = x;
            this.Y = y;
            this.puzzledirection = pd;
            this.number = n;
            this.answer = ans;
            this.puzzleclue = pc; 
        }
    }
}
