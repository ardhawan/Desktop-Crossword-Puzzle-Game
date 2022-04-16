namespace CrosswordPuzzleGame
{
    partial class StartingPage
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
            this.newgame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customgame = new System.Windows.Forms.Button();
            this.endgame = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newgame
            // 
            this.newgame.BackColor = System.Drawing.Color.Red;
            this.newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame.Location = new System.Drawing.Point(49, 116);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(686, 89);
            this.newgame.TabIndex = 0;
            this.newgame.TabStop = false;
            this.newgame.Text = "New Game";
            this.newgame.UseVisualStyleBackColor = false;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Crossword Game";
            // 
            // customgame
            // 
            this.customgame.BackColor = System.Drawing.Color.Yellow;
            this.customgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customgame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customgame.Location = new System.Drawing.Point(116, 228);
            this.customgame.Name = "customgame";
            this.customgame.Size = new System.Drawing.Size(559, 87);
            this.customgame.TabIndex = 1;
            this.customgame.TabStop = false;
            this.customgame.Text = "Custom Game";
            this.customgame.UseVisualStyleBackColor = false;
            this.customgame.Click += new System.EventHandler(this.customgame_Click);
            // 
            // endgame
            // 
            this.endgame.BackColor = System.Drawing.Color.Chartreuse;
            this.endgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endgame.Location = new System.Drawing.Point(181, 343);
            this.endgame.Name = "endgame";
            this.endgame.Size = new System.Drawing.Size(439, 83);
            this.endgame.TabIndex = 2;
            this.endgame.TabStop = false;
            this.endgame.Text = "End Game";
            this.endgame.UseVisualStyleBackColor = false;
            this.endgame.Click += new System.EventHandler(this.endgame_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 49);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(122, 45);
            this.rulesToolStripMenuItem.Text = "RULES";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // StartingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endgame);
            this.Controls.Add(this.customgame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starting Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customgame;
        private System.Windows.Forms.Button endgame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
    }
}

