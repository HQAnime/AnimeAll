
using Microsoft.Toolkit.Wpf.UI.Controls;
using System;

namespace AnimeAll.Core
{
    public class AnimeFactory : AnimeBase
    {
        private AnimeBase anime;
        private static AnimeBase[] animes =
        {
            new Anime9(), 
            new AnimeGo(), 
            new AnimeOne(), 
            new AnimeSakura(),
        };

        public AnimeFactory(Website site)
        {
            IsThisMySite(site);
        }

        public void InjectJS(WebView view)
        {
            anime.InjectJS(view);
        }

        public string WebViewSource()
        {
            Console.WriteLine(anime.WebViewSource());
            return anime.WebViewSource();
        }

        public bool IsThisMySite(Website site)
        {
            foreach (AnimeBase anime in animes)
            {
                if (anime.IsThisMySite(site))
                {
                    this.anime = anime;
                    break;
                }
            }

            return false;
        }
    }
}
