using System.Diagnostics.CodeAnalysis;

namespace Rothko
{
    public interface IDialogFacade
    {
        SaveDialogResult ShowSaveFileDialog(string filterPattern);
    }

    [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes",
        Justification = "TODO: Should tchis even be a struct?")]
    public struct SaveDialogResult
    {
        readonly bool _success;
        readonly string _fileName;

        public SaveDialogResult(bool success, string chosenFileName)
        {
            _success = success;
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
    }
}
