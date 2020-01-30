
using Microsoft.Toolkit.Wpf.UI.Controls;

namespace AnimeAll.Core
{
    class AnimeGo : AnimeBase
    {
        private readonly string[] script = new string[]
        {
            @"$('.image-with-text, .ad-bebi, .bebi-icon-hover, img[border], a[target], .banner_center').remove();",
        };

        public void InjectJS(WebView view)
        {
            view.InvokeScriptAsync("eval", script);
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.AnimeGo;
        }

        public string WebViewSource()
        {
            return "https://www2.gogoanimes.ai/";
        }
    }
}
