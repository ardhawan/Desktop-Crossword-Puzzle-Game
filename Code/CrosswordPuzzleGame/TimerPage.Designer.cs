namespace CrosswordPuzzleGame
{
    partial class TimerPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.easytimer = new System.Windows.Forms.Button();
            this.hardtimer = new System.Windows.Forms.Button();
            this.backpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select one of the below options";
            // 
            // easytimer
            // 
            this.easytimer.BackColor = System.Drawing.Color.Lime;
            this.easytimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easytimer.Location = new System.Drawing.Point(50, 95);
            this.easytimer.Name = "easytimer";
            this.easytimer.Size = new System.Drawing.Size(696, 84);
            this.easytimer.TabIndex = 0;
            this.easytimer.TabStop = false;
            this.easytimer.Text = "Easy Timer";
            this.easytimer.UseVisualStyleBackColor = false;
            this.easytimer.Click += new System.EventHandler(this.easytimer_Click);
            // 
            // hardtimer
            // 
            this.hardtimer.BackColor = System.Drawing.Color.Red;
            this.hardtimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardtimer.Location = new System.Drawing.Point(128, 216);
            this.hardtimer.Name = "hardtimer";
            this.hardtimer.Size = new System.Drawing.Size(539, 89);
            this.hardtimer.TabIndex = 1;
            this.hardtimer.TabStop = false;
            this.hardtimer.Text = "Hard Timer";
            this.hardtimer.UseVisualStyleBackColor = false;
            this.hardtimer.Click += new System.EventHandler(this.hardtimer_Click);
            // 
            // backpage
            // 
            this.backpage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpage.Location = new System.Drawing.Point(192, 344);
            this.backpage.Name = "backpage";
            this.backpage.Size = new System.Drawing.Size(409, 81);
            this.backpage.TabIndex = 2;
            this.backpage.TabStop = false;
            this.backpage.Text = "Back Page";
            this.backpage.UseVisualStyleBackColor = false;
            this.backpage.Click += new System.EventHandler(this.backpage_Click);
            // 
            // TimerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backpage);
            this.Controls.Add(this.hardtimer);
            this.Controls.Add(this.easytimer);
            this.Controls.Add(this.label1);
            this.Name = "TimerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimerPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button easytimer;
        private System.Windows.Forms.Button hardtimer;
        private System.Windows.Forms.Button backpage;
    }
}