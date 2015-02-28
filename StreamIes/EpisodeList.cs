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
    public partial class EpisodeList : UserControl
    {
        private Episode episode;
        private Func<Episode, int> callback;

        public EpisodeList(Episode episode, Func<Episode, int> callback)
        {
            this.episode = episode;
            this.callback = callback;

            InitializeComponent();

            InitUi();
        }

        private void InitUi()
        {
            this.episodeTitle.Text = String.Format("Episode {0} - {1} - Air date: {2}", this.episode.episodeNumberInSeason, this.episode.title, this.episode.airDate.ToString("dd.MM.yyyy"));
            if (this.episode.airDate > DateTime.Now)
            {
                this.episodeTitle.Text += " (Not Aired Yet)";
            }
        }

        private void episde_Enter(object sender, EventArgs e)
        {
            if (this.episode.airDate > DateTime.Now)
            {
                this.BackColor = Color.FromArgb(93, 160, 247);
            }
            else
            {
                this.BackColor = Color.Gray;
            }
        }

        private void episode_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void episode_Click(object sender, EventArgs e)
        {
            this.callback(this.episode);
        }
    }
}
