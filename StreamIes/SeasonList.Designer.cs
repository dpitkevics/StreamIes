namespace StreamIes
{
    partial class SeasonList
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
            this.seasonLabel = new System.Windows.Forms.Label();
            this.seasonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.seasonLabel.ForeColor = System.Drawing.Color.White;
            this.seasonLabel.Location = new System.Drawing.Point(3, 2);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(87, 29);
            this.seasonLabel.TabIndex = 0;
            this.seasonLabel.Text = "Season";
            // 
            // seasonLayout
            // 
            this.seasonLayout.Location = new System.Drawing.Point(0, 34);
            this.seasonLayout.Name = "seasonLayout";
            this.seasonLayout.Size = new System.Drawing.Size(856, 166);
            this.seasonLayout.TabIndex = 1;
            // 
            // SeasonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seasonLayout);
            this.Controls.Add(this.seasonLabel);
            this.Name = "SeasonList";
            this.Size = new System.Drawing.Size(856, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seasonLabel;
        public System.Windows.Forms.FlowLayoutPanel seasonLayout;
    }
}
