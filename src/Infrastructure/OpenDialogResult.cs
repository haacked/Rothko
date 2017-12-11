namespace Rothko
{
    using System.Collections.Generic;
    using System.Linq;
    using NullGuard;

    public struct OpenDialogResult
    {
        readonly bool _success;
        readonly IEnumerable<string> _fileNames;

        public static readonly OpenDialogResult Failed = new OpenDialogResult();

        public OpenDialogResult(IEnumerable<string> chosenFileNames)
        {
            _success = true;
            _fileNames = chosenFileNames;
        }

        public bool Success
        {
            get { return _success; }
        }

        public IEnumerable<string> FileNames
        {
            get { return _fileNames; }
        }

        public override bool Equals([AllowNull]object obj)
        {
            if (!(obj is OpenDialogResult)) return false;
            return this == ((OpenDialogResult)obj);
        }

        public static bool operator ==(OpenDialogResult a, OpenDialogResult b)
        {
            return a._success == b._success && a._fileNames.SequenceEqual(b._fileNames);
        }

        public static bool operator !=(OpenDialogResult a, OpenDialogResult b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (17327 * 67 + _success.GetHashCode()) * 67 + (_fileNames ?? Enumerable.Empty<string>()).GetHashCode();
            }
        }
    }
}