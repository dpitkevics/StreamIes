namespace StreamIes
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.searchQueryBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.searchQueryPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.searchQueryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQueryBox
            // 
            this.searchQueryBox.AcceptsReturn = true;
            this.searchQueryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.searchQueryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchQueryBox.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.searchQueryBox.ForeColor = System.Drawing.Color.Gray;
            this.searchQueryBox.Location = new System.Drawing.Point(3, 13);
            this.searchQueryBox.Margin = new System.Windows.Forms.Padding(10);
            this.searchQueryBox.Name = "searchQueryBox";
            this.searchQueryBox.Size = new System.Drawing.Size(705, 16);
            this.searchQueryBox.TabIndex = 0;
            this.searchQueryBox.Text = "Search...";
            this.searchQueryBox.Enter += new System.EventHandler(this.searchQueryBox_Enter);
            this.searchQueryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchQueryBox_KeyDown);
            this.searchQueryBox.Leave += new System.EventHandler(this.searchQueryBox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.searchQueryPanel);
            this.panel2.Controls.Add(this.dragPanel);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 149);
            this.panel2.TabIndex = 4;
            // 
            // dragPanel
            // 
            this.dragPanel.Location = new System.Drawing.Point(0, 3);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(1046, 32);
            this.dragPanel.TabIndex = 5;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.dragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // searchQueryPanel
            // 
            this.searchQueryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.searchQueryPanel.Controls.Add(this.searchQueryBox);
            this.searchQueryPanel.Controls.Add(this.searchButton);
            this.searchQueryPanel.Location = new System.Drawing.Point(143, 50);
            this.searchQueryPanel.Name = "searchQueryPanel";
            this.searchQueryPanel.Size = new System.Drawing.Size(751, 44);
            this.searchQueryPanel.TabIndex = 6;
            this.searchQueryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchQueryPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::StreamIes.Properties.Resources.close_white;
            this.closeButton.Location = new System.Drawing.Point(1052, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 32);
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = global::StreamIes.Properties.Resources.Search_icon;
            this.searchButton.Location = new System.Drawing.Point(713, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(35, 38);
            this.searchButton.TabIndex = 7;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1096, 813);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "StreamIes";
            this.panel2.ResumeLayout(false);
            this.searchQueryPanel.ResumeLayout(false);
            this.searchQueryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchQueryBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Panel searchQueryPanel;
        private System.Windows.Forms.PictureBox searchButton;
    }
}

