namespace StreamIes
{
    partial class SearchList
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.seasonsLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.hoverPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(295, 100);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.panel_Click);
            this.logo.MouseEnter += new System.EventHandler(this.hoverPanel_MouseEnter);
            this.logo.MouseLeave += new System.EventHandler(this.hoverPanel_MouseLeave);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleLabel.Font = new System.Drawing.Font("DejaVu Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(302, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(144, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Show Title";
            this.titleLabel.Click += new System.EventHandler(this.panel_Click);
            this.titleLabel.MouseEnter += new System.EventHandler(this.hoverPanel_MouseEnter);
            this.titleLabel.MouseLeave += new System.EventHandler(this.hoverPanel_MouseLeave);
            // 
            // seasonsLabel
            // 
            this.seasonsLabel.AutoSize = true;
            this.seasonsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seasonsLabel.ForeColor = System.Drawing.Color.White;
            this.seasonsLabel.Location = new System.Drawing.Point(307, 33);
            this.seasonsLabel.Name = "seasonsLabel";
            this.seasonsLabel.Size = new System.Drawing.Size(54, 13);
            this.seasonsLabel.TabIndex = 2;
            this.seasonsLabel.Text = "Seasons: ";
            this.seasonsLabel.Click += new System.EventHandler(this.panel_Click);
            this.seasonsLabel.MouseEnter += new System.EventHandler(this.hoverPanel_MouseEnter);
            this.seasonsLabel.MouseLeave += new System.EventHandler(this.hoverPanel_MouseLeave);
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genresLabel.ForeColor = System.Drawing.Color.White;
            this.genresLabel.Location = new System.Drawing.Point(308, 50);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(44, 13);
            this.genresLabel.TabIndex = 3;
            this.genresLabel.Text = "Genres:";
            this.genresLabel.Click += new System.EventHandler(this.panel_Click);
            this.genresLabel.MouseEnter += new System.EventHandler(this.hoverPanel_MouseEnter);
            this.genresLabel.MouseLeave += new System.EventHandler(this.hoverPanel_MouseLeave);
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isActiveLabel.ForeColor = System.Drawing.Color.White;
            this.isActiveLabel.Location = new System.Drawing.Point(308, 67);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(51, 13);
            this.isActiveLabel.TabIndex = 4;
            this.isActiveLabel.Text = "Is Active:";
            this.isActiveLabel.Click += new System.EventHandler(this.panel_Click);
            this.isActiveLabel.MouseEnter += new System.EventHandler(this.hoverPanel_MouseEnter);
            this.isActiveLabel.MouseLeave += new System.EventHandler(this.hoverPanel_MouseLeave);
            // 
            // hoverPanel
            // 
            this.hoverPanel.BackColor = System.Drawing.Color.Transparent;
            this.hoverPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoverPanel.Location = new System.Drawing.Point(0, 0);
            this.hoverPanel.Name = "hoverPanel";
            this.hoverPanel.Size = new System.Drawing.Size(856, 100);
            this.hoverPanel.TabIndex = 5;
            this.hoverPanel.Click += new System.EventHandler(this.panel_Click);
            this.hoverPanel.MouseEnter += new System.EventHandler(this.hoverPanel_MouseEnter);
            this.hoverPanel.MouseLeave += new System.EventHandler(this.hoverPanel_MouseLeave);
            // 
            // SearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.seasonsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.hoverPanel);
            this.Name = "SearchList";
            this.Size = new System.Drawing.Size(856, 100);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label seasonsLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.Panel hoverPanel;



    }
}
