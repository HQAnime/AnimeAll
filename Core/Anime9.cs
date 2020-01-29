using System;

namespace AnimeAll.Core
{
    class Anime9 : AnimeBase
    {
        public void InjectJS()
        {

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
