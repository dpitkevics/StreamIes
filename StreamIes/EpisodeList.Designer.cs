namespace StreamIes
{
    partial class EpisodeList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.episodeTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // episodeTitle
            // 
            this.episodeTitle.AutoSize = true;
            this.episodeTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.episodeTitle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.episodeTitle.ForeColor = System.Drawing.Color.White;
            this.episodeTitle.Location = new System.Drawing.Point(26, 10);
            this.episodeTitle.Name = "episodeTitle";
            this.episodeTitle.Size = new System.Drawing.Size(96, 19);
            this.episodeTitle.TabIndex = 0;
            this.episodeTitle.Text = "Episode Title";
            this.episodeTitle.MouseEnter += new System.EventHandler(this.episde_Enter);
            this.episodeTitle.MouseLeave += new System.EventHandler(this.episode_Leave);
            // 
            // EpisodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.episodeTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "EpisodeList";
            this.Size = new System.Drawing.Size(856, 41);
            this.MouseEnter += new System.EventHandler(this.episde_Enter);
            this.MouseLeave += new System.EventHandler(this.episode_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label episodeTitle;
    }
}
