
using Microsoft.Toolkit.Wpf.UI.Controls;

namespace AnimeAll.Core
{
    class AnimeOne : AnimeBase
    {
        private readonly string[] script = new string[]
        {
            //@"$('.widget-title, ins, aside, .sidebar-discord').remove();",
            @"$('.header-content, aside, ins, .site-info').remove();",
        };

        public void InjectJS(WebView view)
        {
            view.InvokeScriptAsync("eval", script);
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.AnimeOne;
        }

        public string WebViewSource()
        {
            return "https://www.anime1.me/關於";
        }
    }
}
