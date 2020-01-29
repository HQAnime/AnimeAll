
namespace AnimeAll.Core
{
    class AnimeGo : AnimeBase
    {
        public void InjectJS()
        {
            throw new System.NotImplementedException();
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.AnimeGo;
        }

        public string WebViewSource()
        {
            throw new System.NotImplementedException();
        }
    }
}
