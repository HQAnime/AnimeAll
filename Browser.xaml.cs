using System.Windows;
using AnimeAll.Core;

namespace AnimeAll
{
    /// <summary>
    /// Interaction logic for Browser.xaml
    /// </summary>
    public partial class Browser : Window
    {
        private AnimeBase anime;
        public Browser(string url)
        {
            InitializeComponent();
        }
    }
}
