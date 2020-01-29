
using Microsoft.Toolkit.Wpf.UI.Controls;

namespace AnimeAll.Core
{
    class AnimeSakura : AnimeBase
    {
        private readonly string[] script = new string[]
        {
            @"$('#bdshare, div[style]').remove();",
        };

        public void InjectJS(WebView view)
        {
            view.InvokeScriptAsync("eval", script);
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.AnimeSakura;
        }

        public string WebViewSource()
        {
            return "http://www.yhdm.tv/";
        }
    }
}
