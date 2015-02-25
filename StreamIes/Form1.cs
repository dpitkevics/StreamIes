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
        SearchListLayout searchListLayout;

        public MainForm()
        {
            InitializeComponent();
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
                    this.addSearchListControlItem(show, i);
                }
                this.Controls.Add(searchListLayout);
            }
        }

        private void addSearchListControlItem(Show show, int row)
        {
            SearchList searchList = new SearchList();

            PictureBox showLogo = new PictureBox();
            showLogo.Load(show.imageUrl);
            searchList.layout.Controls.Add(showLogo, 0, 0);

            Label showTitle = new Label();
            showTitle.Text = show.name;
            searchList.layoutDetails.Controls.Add(showTitle, 1, 0);

            Label showSeasons = new Label();
            showSeasons.Text = String.Format("Seasons: {0}", show.seasons);
            searchList.layoutDetails.Controls.Add(showSeasons, 1, 1);

            Label showGenres = new Label();
            String[] genreLabels = new String[show.genres.Count];
            for (int i = 0; i < show.genres.Count; i++)
            {
                genreLabels[i] = show.genres[i].title;
            }
            showGenres.Text = String.Join(", ", genreLabels);
            searchList.layoutDetails.Controls.Add(showGenres, 1, 2);

            this.searchListLayout.layout.Controls.Add(searchList);
        }
    }
}
