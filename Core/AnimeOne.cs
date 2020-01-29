
namespace AnimeAll.Core
{
    class AnimeOne : AnimeBase
    {
        public void InjectJS()
        {
            throw new System.NotImplementedException();
        }

        public bool IsThisMySite(Website site)
        {
            return site == Website.AnimeOne;
        }

        public string WebViewSource()
        {
            throw new System.NotImplementedException();
        }
    }
}
