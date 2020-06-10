using System;
using NullGuard;

namespace Rothko
{
    public struct BrowseDirectoryResult
    {
        readonly bool _success;
        readonly string _directoryPath;

        /// <summary>
        /// Represents a failed browse result.
        /// </summary>
        public static readonly BrowseDirectoryResult Failed = new BrowseDirectoryResult();

        public BrowseDirectoryResult(string directoryPath)
        {
            if (directoryPath.Length == 0) throw new ArgumentException("Selected path cannot be empty", "directoryPath");

            _success = true;
            _directoryPath = directoryPath;
        }

        public bool Success
        {
            get { return _success; }
        }

        public string DirectoryPath
        {
            get { return _directoryPath; }
        }

        public override bool Equals([AllowNull]object obj)
        {
            if (!(obj is BrowseDirectoryResult)) return false;
            return this == ((BrowseDirectoryResult)obj);
        }

        public static bool operator ==(BrowseDirectoryResult a, BrowseDirectoryResult b)
        {
            return a._success == b._success && a._directoryPath == b._directoryPath;
        }

        public static bool operator !=(BrowseDirectoryResult a, BrowseDirectoryResult b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (17327 * 67 + _success.GetHashCode()) * 67 + (_directoryPath ?? "").GetHashCode();
            }
        }
    }
}