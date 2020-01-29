
namespace AnimeAll.Core
{
    class AnimeOne : AnimeBase
    {
        public void InjectJS()
        {
            
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.AnimeOne;
        }

        public string WebViewSource()
        {
            return "https://anime1.me/";
        }
    }
}
