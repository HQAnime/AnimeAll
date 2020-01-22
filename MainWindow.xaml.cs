using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.UI.ViewManagement;

namespace AnimeAll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string[] script = new string[]
        {
            "$('.image-with-text').remove();",
            "$('.ad-bebi').remove();",
            "$('.anime_video_body_comment_center').remove();",
            "alert('hello world')"
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void weball_NewWindowRequested(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNewWindowRequestedEventArgs e)
        {
            Console.WriteLine(e.ToString());
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

        private void weball_DOMContentLoaded(object sender, WebViewControlDOMContentLoadedEventArgs e)
        {
            weball.InvokeScriptAsync("eval", this.script);
            Console.WriteLine("Script has been invoked");
        }
    }
}
