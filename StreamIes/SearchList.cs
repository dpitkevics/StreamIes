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
    public partial class SearchList : UserControl
    {
        Show show;
        Func<Show, int> callback;

        public SearchList(Show show, Func<Show, int> callback)
        {
            this.show = show;
            this.callback = callback;

            InitializeComponent();
            this.InitDynamicComponenets();
        }

        public void InitDynamicComponenets()
        {
            this.logo.Load(this.show.imageUrl);
            this.titleLabel.Text = this.show.name;
            this.seasonsLabel.Text = String.Format("Seasons: {0}", this.show.seasons);

            String[] genreLabels = new String[this.show.genres.Count];
            for (int i = 0; i < this.show.genres.Count; i++)
            {
                genreLabels[i] = this.show.genres[i].title;
            }
            this.genresLabel.Text = String.Format("Genres: {0}", String.Join(", ", genreLabels));

            this.isActiveLabel.Text = String.Format("Is Active: {0}", show.ended == 0 ? "Yes" : "No");
        }

        private void hoverPanel_MouseEnter(object sender, EventArgs e)
        {
            this.setHoverPanel();
        }

        private void hoverPanel_MouseLeave(object sender, EventArgs e)
        {
            this.removeHoverPanel();
        }

        private void setHoverPanel()
        {
            this.BackColor = Color.FromArgb(28, 28, 31);
        }

        private void removeHoverPanel()
        {
            this.BackColor = Color.Transparent;
        }

        private void panel_Click(object sender, EventArgs e)
        {
            this.callback(this.show);
        }
    }
}
