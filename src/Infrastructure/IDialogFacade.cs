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
        /// Displays an open file dialog and returns the result of the user's interaction with the dialog.
        /// </summary>
        /// <param name="filePattern">Pattern used to filter the files shown.</param>
        /// <param name="multiselect">Indicates whether the dialog box allows multiple files to be selected.</param>
        /// <returns>A <see cref="OpenDialogResult"/> indicating the action taken by the user.</returns>
        OpenDialogResult ShowOpenFileDialog(string filePattern, bool multiselect);

        /// <summary>
        /// Opens a standard Windows browse directory and returns the result.
        /// </summary>
        /// <param name="selectedPath">The default selected path</param>
        /// <param name="title">The title to show on the dialog</param>
        /// <returns></returns>
        BrowseDirectoryResult BrowseForDirectory(string selectedPath, string title);
    }
}
