namespace CrosswordPuzzleGame
{
    partial class PuzzleGraphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleGraphics));
            this.imagebox = new System.Windows.Forms.PictureBox();
            this.ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagebox
            // 
            resources.ApplyResources(this.imagebox, "imagebox");
            this.imagebox.Name = "imagebox";
            this.imagebox.TabStop = false;
            // 
            // ok
            // 
            resources.ApplyResources(this.ok, "ok");
            this.ok.Name = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // PuzzleGraphics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ok);
            this.Controls.Add(this.imagebox);
            this.Name = "PuzzleGraphics";
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.Button ok;
    }
}