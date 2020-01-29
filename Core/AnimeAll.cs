
namespace AnimeAll.Core
{
    public class AnimeAll
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
            foreach (AnimeBase anime in animes)
            {
                if (anime.IsThisMySite(site))
                {
                    this.anime = anime;
                }
            }
        }

        public void InjectJS()
        {
            anime.InjectJS();
        }
    }
}
