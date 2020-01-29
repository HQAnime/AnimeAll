
using System;

namespace AnimeAll.Core
{
    public class AnimeAll : AnimeBase
    {
        private AnimeBase anime;
        private static AnimeBase[] animes =
        {
            new Anime9(), 
            new AnimeGo(), 
            new AnimeOne(), 
            new AnimeSakura(),
        };

        public AnimeAll(Website site)
        {
            IsThisMySite(site);
        }

        public void InjectJS()
        {
            anime.InjectJS();
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
                }
            }

            return false;
        }
    }
}
