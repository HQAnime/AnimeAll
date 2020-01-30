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
            browser.Source = new Uri(anime.WebViewSource());
            this.WindowState = WindowState.Maximized;
        }

        [Obsolete]
        private void browser_ContainsFullScreenElementChanged(object sender, object e)
        {
            if ((sender as WebView).ContainsFullScreenElement)
            {
                // Fullscreen
                window.Visibility = Visibility.Collapsed;
                window.WindowStyle = WindowStyle.None;
                window.ResizeMode = ResizeMode.NoResize;
                window.WindowState = WindowState.Maximized;
                window.Topmost = true;
                window.Visibility = Visibility.Visible;
            }
            else
            {
                // Exit Fullscreen
                window.WindowStyle = WindowStyle.SingleBorderWindow;
                window.WindowState = WindowState.Normal;
                window.ResizeMode = ResizeMode.CanResize;
                window.Topmost = false;
            }
        }

        private void browser_DOMContentLoaded(object sender, WebViewControlDOMContentLoadedEventArgs e)
        {
            anime.InjectJS(browser);
        }

        private void browser_Loaded(object sender, RoutedEventArgs e)
        {
            anime.InjectJS(browser);
        }

        private void window_Closed(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void browser_ContentLoading(object sender, WebViewControlContentLoadingEventArgs e)
        {
            anime.InjectJS(browser);
        }
    }
}
