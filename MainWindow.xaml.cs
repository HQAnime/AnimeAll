using System.Diagnostics;
using System.Windows;
using AnimeAll.Core;

namespace AnimeAll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowBrowser(Website site)
        {
            var browser = new Browser(site);
            browser.ShowDialog();
        }

        private void AnimeGo_Click(object sender, RoutedEventArgs e)
        {
            ShowBrowser(Website.AnimeGo);
        }

        private void Anime9_Click(object sender, RoutedEventArgs e)
        {
            ShowBrowser(Website.Anime9);
        }

        private void AnimeOne_Click(object sender, RoutedEventArgs e)
        {
            var one = new AnimeOne();
            Process.Start(one.WebViewSource());
        }

        private void AnimeSakura_Click(object sender, RoutedEventArgs e)
        {
            ShowBrowser(Website.AnimeSakura);
        }
    }
}
