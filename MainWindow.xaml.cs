using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.Controls;
using System;
using System.Windows;

namespace AnimeAll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string[] script = new string[]
        {
            @"$('.image-with-text, .ad-bebi, .bebi-icon-hover, img[border]').remove();",
        };

        public MainWindow()
        {
            InitializeComponent();
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

        private void injectJS(string msg)
        {
            weball.InvokeScriptAsync("eval", this.script);
            Console.WriteLine("Script has been invoked, " + msg);
        }

        private void weball_FrameDOMContentLoaded(object sender, WebViewControlDOMContentLoadedEventArgs e)
        {
            injectJS("FrameDOM");
        }

        private void weball_DOMContentLoaded(object sender, WebViewControlDOMContentLoadedEventArgs e)
        {
            injectJS("OMContent");
        }
    }
}
