
using Microsoft.Toolkit.Wpf.UI.Controls;

namespace AnimeAll.Core
{
    class AnimeOne : AnimeBase
    {
        private readonly string[] script = new string[]
        {
            @"$('.widget-title').remove();",
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
            return "https://anime1.me/";
        }
    }
}
