namespace CrosswordPuzzleGame
{
    partial class CustomMenu
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
            this.playcustom = new System.Windows.Forms.Button();
            this.addcustom = new System.Windows.Forms.Button();
            this.backpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select one of the below option";
            // 
            // playcustom
            // 
            this.playcustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playcustom.ForeColor = System.Drawing.Color.Red;
            this.playcustom.Location = new System.Drawing.Point(76, 111);
            this.playcustom.Name = "playcustom";
            this.playcustom.Size = new System.Drawing.Size(676, 75);
            this.playcustom.TabIndex = 0;
            this.playcustom.TabStop = false;
            this.playcustom.Text = "Play Custom Puzzle";
            this.playcustom.UseVisualStyleBackColor = true;
            this.playcustom.Click += new System.EventHandler(this.playcustom_Click);
            // 
            // addcustom
            // 
            this.addcustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustom.ForeColor = System.Drawing.Color.Blue;
            this.addcustom.Location = new System.Drawing.Point(76, 232);
            this.addcustom.Name = "addcustom";
            this.addcustom.Size = new System.Drawing.Size(676, 72);
            this.addcustom.TabIndex = 1;
            this.addcustom.TabStop = false;
            this.addcustom.Text = "Add Custom Puzzle";
            this.addcustom.UseVisualStyleBackColor = true;
            this.addcustom.Click += new System.EventHandler(this.addcustom_Click);
            // 
            // backpage
            // 
            this.backpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpage.ForeColor = System.Drawing.Color.DeepPink;
            this.backpage.Location = new System.Drawing.Point(76, 344);
            this.backpage.Name = "backpage";
            this.backpage.Size = new System.Drawing.Size(676, 84);
            this.backpage.TabIndex = 2;
            this.backpage.TabStop = false;
            this.backpage.Text = "Back Page";
            this.backpage.UseVisualStyleBackColor = true;
            this.backpage.Click += new System.EventHandler(this.backpage_Click);
            // 
            // CustomMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backpage);
            this.Controls.Add(this.addcustom);
            this.Controls.Add(this.playcustom);
            this.Controls.Add(this.label1);
            this.Name = "CustomMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playcustom;
        private System.Windows.Forms.Button addcustom;
        private System.Windows.Forms.Button backpage;
    }
}