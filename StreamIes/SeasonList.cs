using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StreamIes.SeriesSearcher;

namespace StreamIes
{
    public partial class SeasonList : UserControl
    {
        private const int EP_HEIGHT = 50;

        Season season;

        public SeasonList(Season season)
        {
            this.season = season;

            InitializeComponent();

            this.InitUi();
        }

        private void InitUi()
        {
            this.Height = this.season.episodes.Count * EP_HEIGHT;
            this.seasonLayout.Height = this.season.episodes.Count * EP_HEIGHT;

            this.seasonLabel.Text = String.Format("Season {0}", this.season.number);
        }
    }
}
