using System.Diagnostics.CodeAnalysis;

namespace Rothko
{
    public interface IDialogFacade
    {
        /// <summary>
        /// Displays a save file dialog and returns the result of the user's interaction with the dialog.
        /// </summary>
        /// <param name="filterPattern">Pattern used to filter the files shown</param>
        /// <returns></returns>
        SaveDialogResult ShowSaveFileDialog(string filterPattern);

        /// <summary>
        /// Opens a standard Windows browse directory and returns the result.
        /// </summary>
        /// <param name="selectedPath">The default selected path</param>
        /// <param name="title">The title to show on the dialog</param>
        /// <returns></returns>
        BrowseDirectoryResult BrowseForDirectory(string selectedPath, string title);
    }
}
