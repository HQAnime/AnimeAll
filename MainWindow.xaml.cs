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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var browser = new Browser(Website.AnimeOne);
            browser.Show();
        }
    }
}
