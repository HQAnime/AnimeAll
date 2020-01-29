using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeAll.Core
{
    interface AnimeBase
    {
        /// <summary>
        /// Inject some JS code to webview (remove ads and more)
        /// </summary>
        void InjectJS();

        /// <summary>
        /// Check if this site is my site
        /// </summary>
        /// <param name="site">one of the webiste enum</param>
        /// <returns>true if enum matches</returns>
        bool IsThisMySite(Website site); 
    }
}
