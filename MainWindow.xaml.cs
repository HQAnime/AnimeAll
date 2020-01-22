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
                rootWindow.Visibility = Visibility.Collapsed;
                rootWindow.WindowStyle = WindowStyle.None;
                rootWindow.ResizeMode = ResizeMode.NoResize;
                rootWindow.WindowState = WindowState.Maximized;
                rootWindow.Topmost = true;
                rootWindow.Visibility = Visibility.Visible;
            }
            else
            {
                rootWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                rootWindow.WindowState = WindowState.Normal;
                rootWindow.ResizeMode = ResizeMode.CanResize;
                rootWindow.Topmost = false;
            }
        }
    }
}
