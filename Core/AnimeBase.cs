using Microsoft.Toolkit.Wpf.UI.Controls;

namespace AnimeAll.Core
{
    interface AnimeBase
    {
        /// <summary>
        /// Inject some JS code to webview (remove ads and more)
        /// </summary>
        void InjectJS(WebView view);

        /// <summary>
        /// Check if this site is my site
        /// </summary>
        /// <param name="site">one of the webiste enum</param>
        /// <returns>true if enum matches</returns>
        bool IsThisMySite(Website site);

        /// <summary>
        /// The source of webview
        /// </summary>
        /// <returns>the website link</returns>
        string WebViewSource();
    }
}
