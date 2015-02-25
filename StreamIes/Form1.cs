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
        public MainForm()
        {
            InitializeComponent();
        }

        delegate void AddSearchListControlCallback(Show show);

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
            Searcher seriesSearcher = new Searcher(this.processSearchCallback);
            Thread seriesSearcherThread = new Thread(() => seriesSearcher.SearchShowsByQuery(searchQueryBox.Text));
            seriesSearcherThread.Start();
        }

        private int processSearchCallback(Results results)
        {
            this.addSearchListControl(results.showList[0]);

            return 1;
        }

        private void addSearchListControl(Show show)
        {
            if (this.InvokeRequired)
            {
                AddSearchListControlCallback d = new AddSearchListControlCallback(addSearchListControl);
                this.Invoke(d, new object[] { show });
            }
            else
            {
                SearchList searchList = new SearchList();
                searchList.Location = new Point(0, 400);
                searchList.showLogo.Load("http://www.newssetup.com/wp-content/uploads/2014/10/Google-Logo-3.jpg");

                this.Controls.Add(searchList);
            }
        }
    }
}
