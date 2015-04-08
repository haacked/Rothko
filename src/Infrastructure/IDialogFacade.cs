using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace Rothko
{
    public interface IDialogFacade
    {
        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which
        /// buttons to show in the message box.</param>
        /// <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which
        /// icon to display in the message box.</param>
        /// <param name="defaultButton">One of the <see cref="MessageBoxDefaultButton"/> values that specifies
        /// the default button for the message box.</param>
        /// <param name="options">One of the <see cref="MessageBoxOptions"/> values that specifies which
        /// display and association options will be used for the message box. You may
        /// pass in 0 if you wish to use the defaults.</param>
        /// <param name="displayHelpButton">true to show the Help button; otherwise, false. The default is false.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            bool displayHelpButton);

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which
        /// buttons to show in the message box.</param>
        /// <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which
        /// icon to display in the message box.</param>
        /// <param name="defaultButton">One of the <see cref="MessageBoxDefaultButton"/> values that specifies
        /// the default button for the message box.</param>
        /// <param name="options">One of the <see cref="MessageBoxOptions"/> values that specifies which
        /// display and association options will be used for the message box. You may
        /// pass in 0 if you wish to use the defaults.</param>
        /// <param name="helpFilePath">The path and name of the Help file to display when the user clicks the Help
        /// button.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            string helpFilePath);

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which
        /// buttons to show in the message box.</param>
        /// <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which
        /// icon to display in the message box.</param>
        /// <param name="defaultButton">One of the <see cref="MessageBoxDefaultButton"/> values that specifies
        /// the default button for the message box.</param>
        /// <param name="options">One of the <see cref="MessageBoxOptions"/> values that specifies which
        /// display and association options will be used for the message box. You may
        /// pass in 0 if you wish to use the defaults.</param>
        /// <param name="helpFilePath">The path and name of the Help file to display when the user clicks the Help
        /// button.</param>
        /// <param name="navigator">One of the <see cref="HelpNavigator"/> values.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            string helpFilePath,
            HelpNavigator navigator);

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which
        /// buttons to show in the message box.</param>
        /// <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which
        /// icon to display in the message box.</param>
        /// <param name="defaultButton">One of the <see cref="MessageBoxDefaultButton"/> values that specifies
        /// the default button for the message box.</param>
        /// <param name="options">One of the <see cref="MessageBoxOptions"/> values that specifies which
        /// display and association options will be used for the message box. You may
        /// pass in 0 if you wish to use the defaults.</param>
        /// <param name="helpFilePath">The path and name of the Help file to display when the user clicks the Help
        /// button.</param>
        /// <param name="navigator">One of the <see cref="HelpNavigator"/> values.</param>
        /// <param name="param">The numeric ID of the Help topic to display when the user clicks the Help
        /// button.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            string helpFilePath,
            HelpNavigator navigator,
            object param);

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which
        /// buttons to show in the message box.</param>
        /// <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which
        /// icon to display in the message box.</param>
        /// <param name="defaultButton">One of the <see cref="MessageBoxDefaultButton"/> values that specifies
        /// the default button for the message box.</param>
        /// <param name="options">One of the <see cref="MessageBoxOptions"/> values that specifies which
        /// display and association options will be used for the message box. You may
        /// pass in 0 if you wish to use the defaults.</param>
        /// <param name="helpFilePath">The path and name of the Help file to display when the user clicks the Help
        /// button.</param>
        /// <param name="keyword">The Help keyword to display when the user clicks the Help button.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        DialogResult ShowMessage(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options,
            string helpFilePath,
            string keyword);

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
