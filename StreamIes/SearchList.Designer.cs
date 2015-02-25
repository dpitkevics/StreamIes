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
            this.showLogo = new System.Windows.Forms.PictureBox();
            this.showTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // showLogo
            // 
            this.showLogo.Location = new System.Drawing.Point(3, 3);
            this.showLogo.Name = "showLogo";
            this.showLogo.Size = new System.Drawing.Size(148, 84);
            this.showLogo.TabIndex = 0;
            this.showLogo.TabStop = false;
            // 
            // showTitle
            // 
            this.showTitle.AutoSize = true;
            this.showTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.showTitle.Location = new System.Drawing.Point(157, 3);
            this.showTitle.Name = "showTitle";
            this.showTitle.Size = new System.Drawing.Size(120, 26);
            this.showTitle.TabIndex = 1;
            this.showTitle.Text = "Homeland";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // SearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showTitle);
            this.Controls.Add(this.showLogo);
            this.Name = "SearchList";
            this.Size = new System.Drawing.Size(598, 90);
            ((System.ComponentModel.ISupportInitialize)(this.showLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showTitle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox showLogo;
    }
}
