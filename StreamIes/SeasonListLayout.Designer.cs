namespace StreamIes
{
    partial class SeasonListLayout
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
            this.seasonMainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // seasonMainLayout
            // 
            this.seasonMainLayout.Location = new System.Drawing.Point(0, 0);
            this.seasonMainLayout.Name = "seasonMainLayout";
            this.seasonMainLayout.Size = new System.Drawing.Size(856, 200);
            this.seasonMainLayout.TabIndex = 0;
            // 
            // SeasonListLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seasonMainLayout);
            this.Name = "SeasonListLayout";
            this.Size = new System.Drawing.Size(856, 200);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel seasonMainLayout;

    }
}
