namespace CrosswordPuzzleGame
{
    partial class CustomPuzzleInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xnumber = new System.Windows.Forms.TextBox();
            this.addinfromation = new System.Windows.Forms.Button();
            this.ynumber = new System.Windows.Forms.TextBox();
            this.direction = new System.Windows.Forms.TextBox();
            this.clue = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cluenumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backpage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customrulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xnumber
            // 
            this.xnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xnumber.Location = new System.Drawing.Point(21, 101);
            this.xnumber.Multiline = true;
            this.xnumber.Name = "xnumber";
            this.xnumber.Size = new System.Drawing.Size(95, 56);
            this.xnumber.TabIndex = 0;
            this.xnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addinfromation
            // 
            this.addinfromation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addinfromation.Location = new System.Drawing.Point(629, 245);
            this.addinfromation.Name = "addinfromation";
            this.addinfromation.Size = new System.Drawing.Size(159, 74);
            this.addinfromation.TabIndex = 1;
            this.addinfromation.Text = "Add";
            this.addinfromation.UseVisualStyleBackColor = true;
            this.addinfromation.Click += new System.EventHandler(this.addinformation_Click);
            // 
            // ynumber
            // 
            this.ynumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ynumber.Location = new System.Drawing.Point(166, 101);
            this.ynumber.Multiline = true;
            this.ynumber.Name = "ynumber";
            this.ynumber.Size = new System.Drawing.Size(91, 56);
            this.ynumber.TabIndex = 6;
            this.ynumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // direction
            // 
            this.direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction.Location = new System.Drawing.Point(307, 101);
            this.direction.Multiline = true;
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(145, 56);
            this.direction.TabIndex = 7;
            this.direction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clue
            // 
            this.clue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clue.Location = new System.Drawing.Point(21, 245);
            this.clue.Multiline = true;
            this.clue.Name = "clue";
            this.clue.Size = new System.Drawing.Size(574, 74);
            this.clue.TabIndex = 8;
            this.clue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(629, 101);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(159, 56);
            this.answer.TabIndex = 9;
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "x-coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "y-coordinate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Clue";
            // 
            // cluenumber
            // 
            this.cluenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cluenumber.Location = new System.Drawing.Point(495, 101);
            this.cluenumber.Multiline = true;
            this.cluenumber.Name = "cluenumber";
            this.cluenumber.Size = new System.Drawing.Size(100, 56);
            this.cluenumber.TabIndex = 15;
            this.cluenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Clue Number";
            // 
            // backpage
            // 
            this.backpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpage.Location = new System.Drawing.Point(21, 360);
            this.backpage.Name = "backpage";
            this.backpage.Size = new System.Drawing.Size(767, 78);
            this.backpage.TabIndex = 17;
            this.backpage.Text = "Back Page";
            this.backpage.UseVisualStyleBackColor = true;
            this.backpage.Click += new System.EventHandler(this.backpage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customrulesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 49);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customrulesToolStripMenuItem
            // 
            this.customrulesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customrulesToolStripMenuItem.Name = "customrulesToolStripMenuItem";
            this.customrulesToolStripMenuItem.Size = new System.Drawing.Size(257, 45);
            this.customrulesToolStripMenuItem.Text = "CUSTOM RULES";
            this.customrulesToolStripMenuItem.Click += new System.EventHandler(this.customrulesToolStripMenuItem_Click);
            // 
            // CustomPuzzleInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backpage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cluenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.clue);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.ynumber);
            this.Controls.Add(this.addinfromation);
            this.Controls.Add(this.xnumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomPuzzleInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inputLevel";
            this.Load += new System.EventHandler(this.CustomPuzzleInformation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xnumber;
        private System.Windows.Forms.Button addinfromation;
        private System.Windows.Forms.TextBox ynumber;
        private System.Windows.Forms.TextBox direction;
        private System.Windows.Forms.TextBox clue;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cluenumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backpage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customrulesToolStripMenuItem;
    }
}