namespace CrosswordPuzzleGame
{
    partial class CustomSetting
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
            this.customtime = new System.Windows.Forms.TextBox();
            this.customlevel = new System.Windows.Forms.TextBox();
            this.addcustom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hourtime = new System.Windows.Forms.RadioButton();
            this.minutetime = new System.Windows.Forms.RadioButton();
            this.levellbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customtime
            // 
            this.customtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customtime.Location = new System.Drawing.Point(463, 90);
            this.customtime.Multiline = true;
            this.customtime.Name = "customtime";
            this.customtime.Size = new System.Drawing.Size(277, 73);
            this.customtime.TabIndex = 1;
            this.customtime.TabStop = false;
            this.customtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customtime.Click += new System.EventHandler(this.customtime_Click);
            // 
            // customlevel
            // 
            this.customlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customlevel.Location = new System.Drawing.Point(44, 90);
            this.customlevel.Multiline = true;
            this.customlevel.Name = "customlevel";
            this.customlevel.Size = new System.Drawing.Size(295, 73);
            this.customlevel.TabIndex = 0;
            this.customlevel.TabStop = false;
            this.customlevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customlevel.Click += new System.EventHandler(this.customlevel_Click);
            this.customlevel.TextChanged += new System.EventHandler(this.customlevel_TextChanged);
            // 
            // addcustom
            // 
            this.addcustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustom.Location = new System.Drawing.Point(44, 339);
            this.addcustom.Name = "addcustom";
            this.addcustom.Size = new System.Drawing.Size(696, 80);
            this.addcustom.TabIndex = 2;
            this.addcustom.TabStop = false;
            this.addcustom.Text = "Play";
            this.addcustom.UseVisualStyleBackColor = true;
            this.addcustom.Click += new System.EventHandler(this.addcustom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter the time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please enter the number of levels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please choose one of the following options";
            // 
            // hourtime
            // 
            this.hourtime.AutoSize = true;
            this.hourtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourtime.Location = new System.Drawing.Point(329, 248);
            this.hourtime.Name = "hourtime";
            this.hourtime.Size = new System.Drawing.Size(105, 40);
            this.hourtime.TabIndex = 8;
            this.hourtime.Text = "Hour";
            this.hourtime.UseVisualStyleBackColor = true;
            // 
            // minutetime
            // 
            this.minutetime.AutoSize = true;
            this.minutetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutetime.Location = new System.Drawing.Point(329, 293);
            this.minutetime.Name = "minutetime";
            this.minutetime.Size = new System.Drawing.Size(132, 40);
            this.minutetime.TabIndex = 9;
            this.minutetime.Text = "Minute";
            this.minutetime.UseVisualStyleBackColor = true;
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.Location = new System.Drawing.Point(12, 185);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(417, 25);
            this.levellbl.TabIndex = 10;
            this.levellbl.Text = "Please enter a whole number (no decimal)";
            this.levellbl.Visible = false;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(340, 185);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(417, 25);
            this.timelbl.TabIndex = 11;
            this.timelbl.Text = "Please enter a whole number (no decimal)";
            this.timelbl.Visible = false;
            // 
            // CustomSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.minutetime);
            this.Controls.Add(this.hourtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addcustom);
            this.Controls.Add(this.customlevel);
            this.Controls.Add(this.customtime);
            this.Name = "CustomSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomGameSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customtime;
        private System.Windows.Forms.TextBox customlevel;
        private System.Windows.Forms.Button addcustom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton hourtime;
        private System.Windows.Forms.RadioButton minutetime;
        private System.Windows.Forms.Label levellbl;
        private System.Windows.Forms.Label timelbl;
    }
}