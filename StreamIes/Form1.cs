using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using StreamIes.SeriesSearcher;

namespace StreamIes
{
    public partial class MainForm : Form
    {
        private SearchListLayout searchListLayout;
        private Loader loader;

        // For window dragging
        private Boolean dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();

            this.loader = new Loader();
        }

        delegate void AddSearchListControlCallback(Results results);

        private void searchQueryBox_Enter(object sender, EventArgs e)
        {
            if (searchQueryBox.Text.Equals("Search..."))
            {
                searchQueryBox.Text = "";
            }
        }

        private void searchQueryBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchQueryBox.Text))
            {
                searchQueryBox.Text = "Search...";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.processSearch(searchQueryBox.Text);
        }

        private void searchQueryBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.processSearch(searchQueryBox.Text);
            }
        }

        private void processSearch(String query)
        {
            this.Controls.Add(this.loader);

            if (this.searchListLayout != null)
            {
                this.Controls.Remove(this.searchListLayout);
            }

            this.searchListLayout = new SearchListLayout();

            Searcher seriesSearcher = new Searcher(this.processSearchCallback);
            Thread seriesSearcherThread = new Thread(() => seriesSearcher.SearchShowsByQuery(searchQueryBox.Text));
            seriesSearcherThread.Start();
        }

        private int processSearchCallback(Results results)
        {
            this.addSearchListControl(results);

            return 1;
        }

        private void addSearchListControl(Results result)
        {
            if (this.InvokeRequired)
            {
                AddSearchListControlCallback d = new AddSearchListControlCallback(addSearchListControl);
                this.Invoke(d, new object[] { result });
            }
            else
            {
                this.searchListLayout.Location = new Point(0, 200);
                this.searchListLayout.Height = result.showList.Count * 100;
                this.searchListLayout.layout.Height = result.showList.Count * 100;

                for (int i = 0; i < result.showList.Count; i++)
                {
                    Show show = result.showList[i];
                    this.addSearchListControlItem(show);
                }
                this.Controls.Add(searchListLayout);

                this.Controls.Remove(this.loader);
            }
        }

        private void addSearchListControlItem(Show show)
        {
            SearchList searchList = new SearchList(show);

            this.searchListLayout.layout.Controls.Add(searchList);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            this.dragCursorPoint = Cursor.Position;
            this.dragFormPoint = this.Location;
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(this.dragCursorPoint));
                this.Location = Point.Add(this.dragFormPoint, new Size(dif));
            }
        }

        private void dragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void searchQueryPanel_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding); 
            myGraphicsPath.AddEllipse(new Rectangle(707, 0, 44, 44));
            myGraphicsPath.AddRectangle(new Rectangle(0, 0, 733, 44));
            this.searchQueryPanel.Region = new Region(myGraphicsPath);
        }
    }
}
