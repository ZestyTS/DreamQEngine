namespace DreamQs
{
    partial class GameForm
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
            this.lblDialogue = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDialogue
            // 
            this.lblDialogue.Location = new System.Drawing.Point(0, 390);
            this.lblDialogue.Name = "lblDialogue";
            this.lblDialogue.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblDialogue.Size = new System.Drawing.Size(1010, 148);
            this.lblDialogue.TabIndex = 0;
            this.lblDialogue.Text = "label1";
            // 
            // pbBackground
            // 
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1010, 538);
            this.pbBackground.TabIndex = 1;
            this.pbBackground.TabStop = false;
            // 
            // GameForm
            // 
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.lblDialogue);
            this.Controls.Add(this.pbBackground);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDialogue;
        private System.Windows.Forms.PictureBox pbBackground;
    }
}
