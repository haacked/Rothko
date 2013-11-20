namespace Rothko
{
    public interface IDialogFacade
    {
        SaveDialogResult ShowSaveFileDialog(string filterPattern);
    }

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
