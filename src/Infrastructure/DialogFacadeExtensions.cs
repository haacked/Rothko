using System.Windows.Forms;

namespace Rothko.Extensions
{
    public static class DialogFacadeExtensions
    {
        private const string DefaultCaption = "";
        private const MessageBoxButtons DefaultButtons = MessageBoxButtons.OK;
        private const MessageBoxIcon DefaultIcon = MessageBoxIcon.None;
        private const MessageBoxDefaultButton DefaultDefaultButton = MessageBoxDefaultButton.Button1;
        private const MessageBoxOptions DefaultOptions = 0;
        private const bool DefaultDisplayHelpButton = false;

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="facade">The <see cref="IDialogFacade"/></param>
        /// <param name="message">The text to display in the message box.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        public static DialogResult ShowMessage(this IDialogFacade facade, string message)
        {
            return facade.ShowMessage(
                message,
                DefaultCaption,
                DefaultButtons,
                DefaultIcon,
                DefaultDefaultButton,
                DefaultOptions,
                DefaultDisplayHelpButton);
        }

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="facade">The <see cref="IDialogFacade"/></param>
        /// <param name="message">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        public static DialogResult ShowMessage(this IDialogFacade facade, string message, string caption)
        {
            return facade.ShowMessage(
                message,
                caption,
                DefaultButtons,
                DefaultIcon,
                DefaultDefaultButton,
                DefaultOptions,
                DefaultDisplayHelpButton);
        }

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="facade">The <see cref="IDialogFacade"/></param>
        /// <param name="message">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which
        /// buttons to show in the message box.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        public static DialogResult ShowMessage(
            this IDialogFacade facade,
            string message,
            string caption,
            MessageBoxButtons buttons)
        {
            return facade.ShowMessage(
                message,
                caption,
                buttons,
                DefaultIcon,
                DefaultDefaultButton,
                DefaultOptions,
                DefaultDisplayHelpButton);
        }

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="facade">The <see cref="IDialogFacade"/></param>
        /// <param name="message">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which
        /// buttons to show in the message box.</param>
        /// <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which
        /// icon to display in the message box.</param>
        public static DialogResult ShowMessage(
            this IDialogFacade facade,
            string message,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon)
        {
            return facade.ShowMessage(
                message,
                caption,
                buttons,
                icon,
                DefaultDefaultButton,
                DefaultOptions,
                DefaultDisplayHelpButton);
        }

        /// <summary>
        /// Displays a message box with specified text, caption, buttons and icon.
        /// </summary>
        /// <param name="facade">The <see cref="IDialogFacade"/></param>
        /// <param name="message">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which
        /// buttons to show in the message box.</param>
        /// <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which
        /// icon to display in the message box.</param>
        /// <param name="defaultButton">One of the <see cref="MessageBoxDefaultButton"/> values that specifies
        /// the default button for the message box.</param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        public static DialogResult ShowMessage(
            this IDialogFacade facade,
            string message,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton)
        {
            return facade.ShowMessage(
                message,
                caption,
                buttons,
                icon,
                defaultButton,
                DefaultOptions,
                DefaultDisplayHelpButton);
        }
    }
}