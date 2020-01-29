
namespace AnimeAll.Core
{
    class AnimeGo : AnimeBase
    {
        public void InjectJS()
        {
            
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
