using AnimeAll.Core;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
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

        private void weball_ContainsFullScreenElementChanged(object sender, object e)
        {
            if ((sender as WebView).ContainsFullScreenElement)
            {
                // Fullscreen
                rootWindow.Visibility = Visibility.Collapsed;
                rootWindow.WindowStyle = WindowStyle.None;
                rootWindow.ResizeMode = ResizeMode.NoResize;
                rootWindow.WindowState = WindowState.Maximized;
                rootWindow.Topmost = true;
                rootWindow.Visibility = Visibility.Visible;
            }
            else
            {
                // Exit Fullscreen
                rootWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                rootWindow.WindowState = WindowState.Normal;
                rootWindow.ResizeMode = ResizeMode.CanResize;
                rootWindow.Topmost = false;
            }
        }

        private void weball_FrameDOMContentLoaded(object sender, WebViewControlDOMContentLoadedEventArgs e)
        {
            anime.InjectJS();
        }

        private void weball_DOMContentLoaded(object sender, WebViewControlDOMContentLoadedEventArgs e)
        {
            anime.InjectJS();
        }
    }
}
