using Microsoft.Toolkit.Wpf.UI.Controls;

namespace AnimeAll.Core
{
    class Anime9 : AnimeBase
    {
        private readonly string[] script = new string[]
        {
            @"$('img[border]').remove();",
        };

        public void InjectJS(WebView view)
        {
            view.InvokeScriptAsync("eval", script);
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.Anime9;
        }

        public string WebViewSource()
        {
            return "https://9animes.ru/9anime.ru";
        }
    }
}
