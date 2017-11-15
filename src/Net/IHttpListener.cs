using System;
using System.Threading.Tasks;
using System.Net;
using System.Security.Authentication.ExtendedProtection;

namespace Rothko
{
    /// <summary>
    ///  Provides a simple, programmatically controlled HTTP protocol listener.
    /// </summary>
    public interface IHttpListener
    {
        /// <summary>
        /// Gets or sets the scheme used to authenticate clients.
        /// </summary>
        /// <returns>
        /// A bitwise combination of System.Net.AuthenticationSchemes enumeration values
        /// that indicates how clients are to be authenticated. The default value is
        /// <see cref="System.Net.AuthenticationSchemes.Anonymous"/>.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        AuthenticationSchemes AuthenticationSchemes { get; set; }

        /// <summary>
        /// Gets or sets the delegate called to determine the protocol used to authenticate
        /// clients.
        /// </summary>
        /// <returns>
        /// An System.Net.AuthenticationSchemeSelector delegate that invokes the method used
        /// to select an authentication protocol. The default value is null.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate { get; set; }

        /// <summary>
        /// Gets a default list of Service Provider Names (SPNs) as determined by registered
        /// prefixes.
        /// </summary>
        /// <returns>
        /// A System.Security.Authentication.ExtendedProtection.ServiceNameCollection that
        /// contains a list of SPNs.
        /// </returns>
        ServiceNameCollection DefaultServiceNames { get; }

        /// <summary>
        /// Get or set the System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy
        /// to use for extended protection for a session.
        /// </summary>
        /// <returns>
        /// A System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy
        /// that specifies the policy to use for extended protection.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// An attempt was made to set the System.Net.HttpListener.ExtendedProtectionPolicy
        /// property, but the System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding
        /// property was not null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// An attempt was made to set the System.Net.HttpListener.ExtendedProtectionPolicy
        /// property to null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// An attempt was made to set the System.Net.HttpListener.ExtendedProtectionPolicy
        /// property after the System.Net.HttpListener.Start method was already called.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        /// <exception cref="PlatformNotSupportedException">
        /// The System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.PolicyEnforcement
        /// property was set to System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always
        /// on a platform that does not support extended protection.
        /// </exception>
        ExtendedProtectionPolicy ExtendedProtectionPolicy { get; set; }

        /// <summary>
        /// Get or set the delegate called to determine the System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy
        /// to use for each request.
        /// </summary>
        /// <returns>
        /// A System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy
        /// that specifies the policy to use for extended protection.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// An attempt was made to set the System.Net.HttpListener.ExtendedProtectionSelectorDelegate
        /// property, but the System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding
        /// property must be null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// An attempt was made to set the System.Net.HttpListener.ExtendedProtectionSelectorDelegate
        /// property to null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// An attempt was made to set the System.Net.HttpListener.ExtendedProtectionSelectorDelegate
        /// property after the System.Net.HttpListener.Start method was already called.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        /// <exception cref="PlatformNotSupportedException">
        /// An attempt was made to set the System.Net.HttpListener.ExtendedProtectionSelectorDelegate
        /// property on a platform that does not support extended protection.
        /// </exception>
        HttpListener.ExtendedProtectionSelector ExtendedProtectionSelectorDelegate { get; set; }

        /// <summary>
        /// Gets or sets a System.Boolean value that specifies whether your application receives
        /// exceptions that occur when an System.Net.HttpListener sends the response to the
        /// client.
        /// </summary>
        /// <returns>
        /// true if this System.Net.HttpListener should not return exceptions that occur
        /// when sending the response to the client; otherwise false. The default value is
        /// false.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        bool IgnoreWriteExceptions { get; set; }

        /// <summary>
        /// Gets a value that indicates whether System.Net.HttpListener has been started.
        /// </summary>
        /// <returns>
        /// true if the System.Net.HttpListener was started; otherwise, false.
        /// </returns>
        bool IsListening { get; }

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) prefixes handled by this System.Net.HttpListener
        /// object.
        /// </summary>
        /// <returns>
        /// An System.Net.HttpListenerPrefixCollection that contains the URI prefixes that
        /// this System.Net.HttpListener object is configured to handle.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        HttpListenerPrefixCollection Prefixes { get; }

        /// <summary>
        /// Gets or sets the realm, or resource partition, associated with this System.Net.HttpListener
        /// object.
        /// </summary>
        /// <returns>
        /// A System.String value that contains the name of the realm associated with the
        /// System.Net.HttpListener object.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        string Realm { get; set; }

        /// <summary>
        /// The timeout manager for this System.Net.HttpListener instance.
        /// </summary>
        /// <returns>
        /// Returns System.Net.HttpListenerTimeoutManager.The timeout manager for this System.Net.HttpListener
        /// instance.
        /// </returns>
        HttpListenerTimeoutManager TimeoutManager { get; }

        /// <summary>
        /// Gets or sets a System.Boolean value that controls whether, when NTLM is used,
        /// additional requests using the same Transmission Control Protocol (TCP) connection
        /// are required to authenticate.
        ///
        /// <returns>
        /// true if the System.Security.Principal.IIdentity of the first request will be
        /// used for subsequent requests on the same connection; otherwise, false. The default
        /// value is false.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        bool UnsafeConnectionNtlmAuthentication { get; set; }

        /// <summary>
        /// Shuts down the System.Net.HttpListener object immediately, discarding all currently
        /// queued requests.
        /// </summary>
        void Abort();

        /// <summary>
        /// Begins asynchronously retrieving an incoming request.
        /// </summary>
        /// <param name="callback">
        /// An System.AsyncCallback delegate that references the method to invoke when a
        /// client request is available.
        /// </param>
        /// <param name="state">
        /// A user-defined object that contains information about the operation. This object
        /// is passed to the callback delegate when the operation completes.
        /// </param>
        /// <returns>
        /// An System.IAsyncResult object that indicates the status of the asynchronous operation.
        /// </returns>
        /// <exception cref="HttpListenerException">
        /// A Win32 function call failed. Check the exception's <see cref="HttpListenerException.ErrorCode"/>
        /// property to determine the cause of the exception.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// This object has not been started or is currently stopped.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        IAsyncResult BeginGetContext(AsyncCallback callback, object state);

        /// <summary>
        /// Shuts down the System.Net.HttpListener.
        /// </summary>
        void Close();

        /// <summary>
        /// Completes an asynchronous operation to retrieve an incoming client request.
        /// </summary>
        /// <param name="asyncResult">
        /// An System.IAsyncResult object that was obtained when the asynchronous operation
        /// was started.
        /// </param>
        /// <returns>
        /// An System.Net.HttpListenerContext object that represents the client request.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// asyncResult was not obtained by calling the 
        /// <see cref="HttpListener.BeginGetContext(System.AsyncCallback,System.Object)"/>
        /// method.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// asyncResult is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// The System.Net.HttpListener.EndGetContext(System.IAsyncResult) method was already
        /// called for the specified asyncResult object.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        IHttpListenerContext EndGetContext(IAsyncResult asyncResult);

        /// <summary>
        /// Waits for an incoming request and returns when one is received.
        /// </summary>
        /// <returns>
        /// An System.Net.HttpListenerContext object that represents a client request.
        /// </returns>
        /// <exception cref="HttpListenerException">
        /// A Win32 function call failed. Check the exception's <see cref="HttpListenerException.ErrorCode"/>
        /// property to determine the cause of the exception.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// This object has not been started or is currently stopped.-or-The System.Net.HttpListener
        /// does not have any Uniform Resource Identifier (URI) prefixes to respond to. See
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        IHttpListenerContext GetContext();

        /// <summary>
        /// Waits for an incoming request as an asynchronous operation.
        /// </summary>
        /// <returns>
        /// Returns System.Threading.Tasks.Task`1.The task object representing the asynchronous
        /// operation. The System.Threading.Tasks.Task`1.Result property on the task object
        /// returns an System.Net.HttpListenerContext object that represents a client request.
        /// </returns>
        Task<IHttpListenerContext> GetContextAsync();

        /// <summary>
        /// Allows this instance to receive incoming requests.
        /// </summary>
        /// <exception cref="HttpListenerException">
        /// A Win32 function call failed. Check the exception's <see cref="HttpListenerException.ErrorCode"/>
        /// property to determine the cause of the exception.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        void Start();

        /// <summary>
        /// Causes this instance to stop receiving incoming requests.
        /// </summary>
        /// <exception cref="ObjectDisposedException">
        /// This object has been closed.
        /// </exception>
        void Stop();
    }
}
