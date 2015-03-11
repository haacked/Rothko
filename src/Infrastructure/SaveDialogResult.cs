using NullGuard;

namespace Rothko
{
    public struct SaveDialogResult
    {
        readonly bool _success;
        readonly string _fileName;

        public static readonly SaveDialogResult Failed = new SaveDialogResult();

        public SaveDialogResult(string chosenFileName)
        {
            _success = true;
            _fileName = chosenFileName;
        }

        public bool Success
        {
            get { return _success; }
        }

        public string FileName
        {
            get { return _fileName; }
        }

        public override bool Equals([AllowNull]object obj)
        {
            if (!(obj is SaveDialogResult)) return false;
            return this == ((SaveDialogResult)obj);
        }

        public static bool operator ==(SaveDialogResult a, SaveDialogResult b)
        {
            return a._success == b._success && a._fileName == b._fileName;
        }

        public static bool operator !=(SaveDialogResult a, SaveDialogResult b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (17327 * 67 + _success.GetHashCode()) * 67 + (_fileName ?? "").GetHashCode();
            }
        }
    }
}