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

        public SearchList(Show show)
        {
            this.show = show;

            InitializeComponent();
            this.InitDynamicComponenets();
        }

        public void InitDynamicComponenets()
        {
            PictureBox showLogo = new PictureBox();
            showLogo.Load(this.show.imageUrl);
            this.layout.Controls.Add(showLogo, 0, 0);

            Label showTitle = new Label();
            showTitle.Text = this.show.name;
            this.layoutDetails.Controls.Add(showTitle, 1, 0);

            Label showSeasons = new Label();
            showSeasons.Text = String.Format("Seasons: {0}", this.show.seasons);
            this.layoutDetails.Controls.Add(showSeasons, 1, 1);

            Label showGenres = new Label();
            String[] genreLabels = new String[this.show.genres.Count];
            for (int i = 0; i < this.show.genres.Count; i++)
            {
                genreLabels[i] = this.show.genres[i].title;
            }
            showGenres.Text = String.Join(", ", genreLabels);
            this.layoutDetails.Controls.Add(showGenres, 1, 2);
        }
    }
}
