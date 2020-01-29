using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeAll.Core
{
    abstract class AnimeBase
    {
        /// <summary>
        /// Inject some JS code to webview (remove ads and more)
        /// </summary>
        public abstract void InjectJS();
    }
}
