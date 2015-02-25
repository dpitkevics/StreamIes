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
            Console.WriteLine("callback processed");

            return 1;
        }
    }
}
