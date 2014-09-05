using System.ComponentModel.Composition;
using Microsoft.Win32;

namespace Rothko
{
    [Export(typeof(IDialogFacade))]
    public class DialogFacade : IDialogFacade
    {
        public SaveDialogResult ShowSaveFileDialog(string filterPattern)
        {
            var dialog = new SaveFileDialog()
            {
                Filter = filterPattern // ex: "Markdown Files(*.md)|*.md|All(*.*)|*"
            };

            return dialog.ShowDialog() == true
                ? new SaveDialogResult(true, dialog.FileName)
                : new SaveDialogResult(false, null);
        }
    }
}
