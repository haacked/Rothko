using System;

namespace Rothko
{
    public interface IBrowser
    {
        /// <summary>
        /// Opens the user's default browser to the specified URL.
        /// </summary>
        /// <param name="url"></param>
        void OpenUrl(Uri url);

        /// <summary>
        /// Opens the user's default browser to the specified URL and returns false if it was unable to.
        /// </summary>
        /// <param name="url"></param>
        bool TryOpenUrl(Uri url);
    }
}

