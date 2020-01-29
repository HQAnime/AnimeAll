using AnimeAll.Core;
using System.Windows;

namespace AnimeAll
{
    /// <summary>
    /// Interaction logic for Browser.xaml
    /// </summary>
    public partial class Browser : Window
    {
        private Core.AnimeAll anime;

        public Browser(Website site)
        {
            InitializeComponent();
            anime = new Core.AnimeAll(site);
        }


    }
}
