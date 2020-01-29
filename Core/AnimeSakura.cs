
namespace AnimeAll.Core
{
    class AnimeSakura : AnimeBase
    {
        public void InjectJS()
        {
            throw new System.NotImplementedException();
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.AnimeSakura;
        }

        public string WebViewSource()
        {
            throw new System.NotImplementedException();
        }
    }
}
