using System;
using AnimeAll.Core;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.Controls;
using System.Windows;

namespace AnimeAll
{
    /// <summary>
    /// Interaction logic for Browser.xaml
    /// </summary>
    public partial class Browser : Window
    {
        private AnimeFactory anime;

        public Browser(Website site)
        {
            InitializeComponent();
            anime = new AnimeFactory(site);
            weball.Source = new Uri(anime.WebViewSource());
        }

        [Obsolete]
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
            Console.WriteLine(e.ToString());
            //anime.InjectJS();
        }

        private void weball_DOMContentLoaded(object sender, WebViewControlDOMContentLoadedEventArgs e)
        {
            Console.WriteLine(e.ToString());
            //anime.InjectJS();
        }
    }
}
