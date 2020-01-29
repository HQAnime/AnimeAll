
namespace AnimeAll.Core
{
    class AnimeSakura : AnimeBase
    {
        public void InjectJS()
        {
            
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.AnimeSakura;
        }

        public string WebViewSource()
        {
            return "http://m.yhdm.tv/";
        }
    }
}
