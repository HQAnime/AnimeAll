using System;

namespace AnimeAll.Core
{
    class Anime9 : AnimeBase
    {
        public void InjectJS()
        {
            throw new NotImplementedException();
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.Anime9;
        }

        public string WebViewSource()
        {
            throw new NotImplementedException();
        }
    }
}
