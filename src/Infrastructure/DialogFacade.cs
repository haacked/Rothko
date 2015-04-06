using System.Windows.Forms;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;

namespace Rothko
{
    public class DialogFacade : IDialogFacade
    {
        public DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            bool displayHelpButton)
        {
            return MessageBox.Show(text, caption, buttons, icon, defaultButton, options, displayHelpButton);
        }

        public DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            string helpFilePath)
        {
            return MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath);
        }

        public DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            string helpFilePath,
            HelpNavigator navigator)
        {
            return MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator);
        }

        public DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            string helpFilePath,
            HelpNavigator navigator,
            object param)
        {
            return MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, navigator, param);
        }

        public DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            string helpFilePath,
            string keyword)
        {
            return MessageBox.Show(text, caption, buttons, icon, defaultButton, options, helpFilePath, keyword);
        }

        public SaveDialogResult ShowSaveFileDialog(string filterPattern)
        {
            var dialog = new SaveFileDialog()
            {
                Filter = filterPattern // ex: "Markdown Files(*.md)|*.md|All(*.*)|*"
            };

            return dialog.ShowDialog() == true
                ? new SaveDialogResult(dialog.FileName)
                : SaveDialogResult.Failed;
        }

        public OpenDialogResult ShowOpenFileDialog(string filePattern, bool multiselect)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = multiselect;
                dialog.Filter = filePattern;
                var result = dialog.ShowDialog();
                return result == DialogResult.OK
                    ? new OpenDialogResult(dialog.FileNames)
                    : new OpenDialogResult();
            }
        }

        public BrowseDirectoryResult BrowseForDirectory(string selectedPath, string title)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.RootFolder = System.Environment.SpecialFolder.Desktop;
                folderBrowser.SelectedPath = selectedPath;
                folderBrowser.ShowNewFolderButton = false;

                if (title != null)
                {
                    folderBrowser.Description = title;
                }

                var dialogResult = folderBrowser.ShowDialog();

                return dialogResult == DialogResult.OK
                    ? new BrowseDirectoryResult(folderBrowser.SelectedPath)
                    : BrowseDirectoryResult.Failed;
            }
        }
    }
}
