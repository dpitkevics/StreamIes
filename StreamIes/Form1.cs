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
        public const int SLI_HEIGHT = 110;

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
        delegate int AddShowSelectControlCallback(Show show);

        private void searchQueryBox_Enter(object sender, EventArgs e)
        {
            if (searchQueryBox.Text.Equals("Search..."))
            {
                searchQueryBox.Text = "";
            }

            searchQueryBox.BackColor = Color.White;
            searchQueryPanel.BackColor = Color.White;
        }

        private void searchQueryBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchQueryBox.Text))
            {
                searchQueryBox.Text = "Search...";
            }

            searchQueryBox.BackColor = Color.FromArgb(223, 224, 230);
            searchQueryPanel.BackColor = Color.FromArgb(223, 224, 230);
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

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void processSearch(String query)
        {
            this.ActiveControl = null;

            this.Controls.Add(this.loader);

            if (this.searchListLayout != null)
            {
                this.contentPanel.Visible = false;
                this.contentPanel.Controls.Remove(this.searchListLayout);
            }

            this.searchListLayout = new SearchListLayout();

            Searcher seriesSearcher = new Searcher();
            seriesSearcher.callback = this.processSearchCallback;
            
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
                this.searchListLayout.Location = new Point(0, 0);
                this.searchListLayout.Height = result.showList.Count * SLI_HEIGHT;
                this.searchListLayout.layout.Height = result.showList.Count * SLI_HEIGHT;

                for (int i = 0; i < result.showList.Count; i++)
                {
                    Show show = result.showList[i];
                    this.addSearchListControlItem(show);
                }
                this.contentPanel.Controls.Add(this.searchListLayout);
                this.contentPanel.Visible = true;
                this.ActiveControl = this.contentPanel;

                this.Controls.Remove(this.loader);
            }
        }

        private void addSearchListControlItem(Show show)
        {
            SearchList searchList = new SearchList(show, searchListItemClickCallback);

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

        private void searchQueryPanel_Click(object sender, EventArgs e)
        {
            this.ActiveControl = searchQueryBox;
        }

        private int searchListItemClickCallback(Show show)
        {
            this.contentPanel.Visible = false;
            this.contentPanel.Controls.Remove(this.searchListLayout);

            this.Controls.Add(this.loader);

            Searcher seriesSearcher = new Searcher();
            seriesSearcher.callbackShow = this.processShowSelectCallback;

            Thread seriesSearcherThread = new Thread(() => seriesSearcher.SearchShowDataById(show));
            seriesSearcherThread.Start();

            return 1;
        }

        private int processShowSelectCallback(Show show)
        {
            if (this.InvokeRequired)
            {
                AddShowSelectControlCallback d = new AddShowSelectControlCallback(processShowSelectCallback);
                this.Invoke(d, new object[] { show });
            }
            else
            {
                SeasonListLayout seasonListLayout = new SeasonListLayout();
                seasonListLayout.Location = new Point(0, 0);
                seasonListLayout.Height = show.seasonsList.Count * SLI_HEIGHT;
                seasonListLayout.seasonMainLayout.Height = show.seasonsList.Count * SLI_HEIGHT;

                foreach (Season season in show.seasonsList)
                {
                    SeasonList seasonList = new SeasonList();

                    seasonListLayout.Controls.Add(seasonList);
                }

                this.contentPanel.Controls.Add(seasonListLayout);
                this.contentPanel.Visible = true;

                this.Controls.Remove(this.loader);
            }

            return 1;
        }
    }
}
