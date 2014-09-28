using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Net.Cache;

namespace Rothko
{
    public interface IWebClient : IDisposable
    {
        byte[] DownloadData(string address);

        /// <summary>
        /// Downloads the resource as a <see cref="T:System.Byte"/> array from the URI specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Byte"/> array containing the downloaded resource.
        /// </returns>
        /// <param name="address">The URI represented by the <see cref="T:System.Uri"/>  object, from which to download data.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        byte[] DownloadData(Uri address);

        void DownloadFile(string address, string fileName);
        void DownloadFile(Uri address, string fileName);
        System.IO.Stream OpenRead(string address);

        /// <summary>
        /// Opens a readable stream for the data downloaded from a resource with the URI specified as a <see cref="T:System.Uri"/>
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.IO.Stream"/> used to read data from a resource.
        /// </returns>
        /// <param name="address">The URI specified as a <see cref="T:System.Uri"/> from which to download data. </param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        /// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/>, <paramref name="address"/> is invalid.-or- An error occurred while downloading data. </exception>
        System.IO.Stream OpenRead(Uri address);

        System.IO.Stream OpenWrite(string address);

        /// <summary>
        /// Opens a stream for writing data to the specified resource.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.IO.Stream"/> used to write data to the resource.
        /// </returns>
        /// <param name="address">The URI of the resource to receive the data.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        /// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/>, and <paramref name="address"/> is invalid.-or- An error occurred while opening the stream. </exception>
        System.IO.Stream OpenWrite(Uri address);

        System.IO.Stream OpenWrite(string address, string method);
        System.IO.Stream OpenWrite(Uri address, string method);
        byte[] UploadData(string address, byte[] data);
        byte[] UploadData(Uri address, byte[] data);
        byte[] UploadData(string address, string method, byte[] data);
        byte[] UploadData(Uri address, string method, byte[] data);
        byte[] UploadFile(string address, string fileName);
        byte[] UploadFile(Uri address, string fileName);
        byte[] UploadFile(string address, string method, string fileName);
        byte[] UploadFile(Uri address, string method, string fileName);
        byte[] UploadValues(string address, NameValueCollection data);

        /// <summary>
        /// Uploads the specified name/value collection to the resource identified by the specified URI.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Byte"/> array containing the body of the response from the resource.
        /// </returns>
        /// <param name="address">The URI of the resource to receive the collection. </param>
        /// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection"/> to send to the resource. </param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null.-or-The <paramref name="data"/> parameter is null.</exception>
        /// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/>, and <paramref name="address"/> is invalid.-or- <paramref name="data"/> is null.-or- There was no response from the server hosting the resource.-or- An error occurred while opening the stream.-or- The Content-type header is not null or "application/x-www-form-urlencoded". </exception>
        byte[] UploadValues(Uri address, NameValueCollection data);

        byte[] UploadValues(string address, string method, NameValueCollection data);
        byte[] UploadValues(Uri address, string method, NameValueCollection data);
        string UploadString(string address, string data);
        string UploadString(Uri address, string data);
        string UploadString(string address, string method, string data);
        string UploadString(Uri address, string method, string data);
        string DownloadString(string address);

        /// <summary>
        /// Downloads the requested resource as a <see cref="T:System.String"/>. The resource to download is specified as a <see cref="T:System.Uri"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.String"/> containing the requested resource.
        /// </returns>
        /// <param name="address">A <see cref="T:System.Uri"/> object containing the URI to download.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        /// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and <paramref name="address"/> is invalid.-or- An error occurred while downloading the resource. </exception><exception cref="T:System.NotSupportedException">The method has been called simultaneously on multiple threads.</exception>
        string DownloadString(Uri address);

        /// <summary>
        /// Opens a readable stream containing the specified resource. This method does not block the calling thread.
        /// </summary>
        /// <param name="address">The URI of the resource to retrieve.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        /// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and address is invalid.-or- An error occurred while downloading the resource. -or- An error occurred while opening the stream.</exception>
        void OpenReadAsync(Uri address);

        void OpenReadAsync(Uri address, object userToken);

        /// <summary>
        /// Opens a stream for writing data to the specified resource. This method does not block the calling thread.
        /// </summary>
        /// <param name="address">The URI of the resource to receive the data. </param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        void OpenWriteAsync(Uri address);

        void OpenWriteAsync(Uri address, string method);
        void OpenWriteAsync(Uri address, string method, object userToken);

        /// <summary>
        /// Downloads the resource specified as a <see cref="T:System.Uri"/>. This method does not block the calling thread.
        /// </summary>
        /// <param name="address">A <see cref="T:System.Uri"/> containing the URI to download.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        /// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and <paramref name="address"/> is invalid.-or- An error occurred while downloading the resource. </exception>
        void DownloadStringAsync(Uri address);

        void DownloadStringAsync(Uri address, object userToken);

        /// <summary>
        /// Downloads the resource as a <see cref="T:System.Byte"/> array from the URI specified as an asynchronous operation.
        /// </summary>
        /// <param name="address">A <see cref="T:System.Uri"/> containing the URI to download.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        /// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and <paramref name="address"/> is invalid.-or- An error occurred while downloading the resource. </exception>
        void DownloadDataAsync(Uri address);

        void DownloadDataAsync(Uri address, object userToken);
        void DownloadFileAsync(Uri address, string fileName);
        void DownloadFileAsync(Uri address, string fileName, object userToken);
        void UploadStringAsync(Uri address, string data);
        void UploadStringAsync(Uri address, string method, string data);
        void UploadStringAsync(Uri address, string method, string data, object userToken);
        void UploadDataAsync(Uri address, byte[] data);
        void UploadDataAsync(Uri address, string method, byte[] data);
        void UploadDataAsync(Uri address, string method, byte[] data, object userToken);
        void UploadFileAsync(Uri address, string fileName);
        void UploadFileAsync(Uri address, string method, string fileName);
        void UploadFileAsync(Uri address, string method, string fileName, object userToken);

        /// <summary>
        /// Uploads the data in the specified name/value collection to the resource identified by the specified URI. This method does not block the calling thread.
        /// </summary>
        /// <param name="address">The URI of the resource to receive the collection. This URI must identify a resource that can accept a request sent with the default method. See remarks.</param>
        /// <param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection"/> to send to the resource.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null.-or-The <paramref name="data"/> parameter is null.</exception><exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and <paramref name="address"/> is invalid.-or- There was no response from the server hosting the resource.</exception>
        void UploadValuesAsync(Uri address, NameValueCollection data);

        void UploadValuesAsync(Uri address, string method, NameValueCollection data);
        void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken);

        /// <summary>
        /// Cancels a pending asynchronous operation.
        /// </summary>
        /// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/></PermissionSet>
        void CancelAsync();

        System.Threading.Tasks.Task DownloadStringTaskAsync(string address);

        /// <summary>
        /// Downloads the resource as a <see cref="T:System.String"/> from the URI specified as an asynchronous operation using a task object.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task"/>.The task object representing the asynchronous operation. The <see cref="P:System.Threading.Tasks.Task.Result"/> property on the task object returns a <see cref="T:System.Byte"/> array containing the downloaded resource.
        /// </returns>
        /// <param name="address">The URI of the resource to download.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception>
        /// <exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and <paramref name="address"/> is invalid.-or- An error occurred while downloading the resource. </exception>
        System.Threading.Tasks.Task DownloadStringTaskAsync(Uri address);

        System.Threading.Tasks.Task OpenReadTaskAsync(string address);

        /// <summary>
        /// Opens a readable stream containing the specified resource as an asynchronous operation using a task object.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task"/>.The task object representing the asynchronous operation. The <see cref="P:System.Threading.Tasks.Task.Result"/> property on the task object returns a <see cref="T:System.IO.Stream"/> used to read data from a resource.
        /// </returns>
        /// <param name="address">The URI of the resource to retrieve.</param><exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception><exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and address is invalid.-or- An error occurred while downloading the resource. -or- An error occurred while opening the stream.</exception>
        System.Threading.Tasks.Task OpenReadTaskAsync(Uri address);

        System.Threading.Tasks.Task OpenWriteTaskAsync(string address);

        /// <summary>
        /// Opens a stream for writing data to the specified resource as an asynchronous operation using a task object.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task"/>.The task object representing the asynchronous operation. The <see cref="P:System.Threading.Tasks.Task.Result"/> property on the task object returns a <see cref="T:System.IO.Stream"/> used to write data to the resource.
        /// </returns>
        /// <param name="address">The URI of the resource to receive the data.</param><exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception><exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and <paramref name="address"/> is invalid.-or- An error occurred while opening the stream. </exception>
        System.Threading.Tasks.Task OpenWriteTaskAsync(Uri address);

        System.Threading.Tasks.Task OpenWriteTaskAsync(string address, string method);
        System.Threading.Tasks.Task OpenWriteTaskAsync(Uri address, string method);
        System.Threading.Tasks.Task UploadStringTaskAsync(string address, string data);
        System.Threading.Tasks.Task UploadStringTaskAsync(Uri address, string data);
        System.Threading.Tasks.Task UploadStringTaskAsync(string address, string method, string data);
        System.Threading.Tasks.Task UploadStringTaskAsync(Uri address, string method, string data);
        System.Threading.Tasks.Task DownloadDataTaskAsync(string address);

        /// <summary>
        /// Downloads the resource as a <see cref="T:System.Byte"/> array from the URI specified as an asynchronous operation using a task object.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task"/>.The task object representing the asynchronous operation. The <see cref="P:System.Threading.Tasks.Task.Result"/> property on the task object returns a <see cref="T:System.Byte"/> array containing the downloaded resource.
        /// </returns>
        /// <param name="address">The URI of the resource to download.</param><exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null. </exception><exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/> and <paramref name="address"/> is invalid.-or- An error occurred while downloading the resource. </exception>
        System.Threading.Tasks.Task DownloadDataTaskAsync(Uri address);

        System.Threading.Tasks.Task DownloadFileTaskAsync(string address, string fileName);
        System.Threading.Tasks.Task DownloadFileTaskAsync(Uri address, string fileName);
        System.Threading.Tasks.Task UploadDataTaskAsync(string address, byte[] data);
        System.Threading.Tasks.Task UploadDataTaskAsync(Uri address, byte[] data);
        System.Threading.Tasks.Task UploadDataTaskAsync(string address, string method, byte[] data);
        System.Threading.Tasks.Task UploadDataTaskAsync(Uri address, string method, byte[] data);
        System.Threading.Tasks.Task UploadFileTaskAsync(string address, string fileName);
        System.Threading.Tasks.Task UploadFileTaskAsync(Uri address, string fileName);
        System.Threading.Tasks.Task UploadFileTaskAsync(string address, string method, string fileName);
        System.Threading.Tasks.Task UploadFileTaskAsync(Uri address, string method, string fileName);
        System.Threading.Tasks.Task UploadValuesTaskAsync(string address, NameValueCollection data);
        System.Threading.Tasks.Task UploadValuesTaskAsync(string address, string method, NameValueCollection data);

        /// <summary>
        /// Uploads the specified name/value collection to the resource identified by the specified URI as an asynchronous operation using a task object.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task"/>.The task object representing the asynchronous operation. The <see cref="P:System.Threading.Tasks.Task.Result"/> property on the task object returns a <see cref="T:System.Byte"/> array containing the response sent by the server.
        /// </returns>
        /// <param name="address">The URI of the resource to receive the collection.</param><param name="data">The <see cref="T:System.Collections.Specialized.NameValueCollection"/> to send to the resource.</param><exception cref="T:System.ArgumentNullException">The <paramref name="address"/> parameter is null.-or-The <paramref name="data"/> parameter is null.</exception><exception cref="T:System.Net.WebException">The URI formed by combining <see cref="P:System.Net.WebClient.BaseAddress"/>, and <paramref name="address"/> is invalid.-or- An error occurred while opening the stream.-or- There was no response from the server hosting the resource.-or- The Content-type header value is not null and is not application/x-www-form-urlencoded. </exception>
        System.Threading.Tasks.Task UploadValuesTaskAsync(Uri address, NameValueCollection data);

        System.Threading.Tasks.Task UploadValuesTaskAsync(Uri address, string method, NameValueCollection data);

        /// <summary>
        /// Gets and sets the <see cref="T:System.Text.Encoding"/> used to upload and download strings.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Text.Encoding"/> that is used to encode strings. The default value of this property is the encoding returned by <see cref="P:System.Text.Encoding.Default"/>.
        /// </returns>
        System.Text.Encoding Encoding { get; set; }

        /// <summary>
        /// Gets or sets the base URI for requests made by a <see cref="T:System.Net.WebClient"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.String"/> containing the base URI for requests made by a <see cref="T:System.Net.WebClient"/> or <see cref="F:System.String.Empty"/> if no base address has been specified.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><see cref="P:System.Net.WebClient.BaseAddress"/> is set to an invalid URI. The inner exception may contain information that will help you locate the error.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        string BaseAddress { get; set; }

        /// <summary>
        /// Gets or sets the network credentials that are sent to the host and used to authenticate the request.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Net.ICredentials"/> containing the authentication credentials for the request. The default is null.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/></PermissionSet>
        ICredentials Credentials { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean"/> value that controls whether the <see cref="P:System.Net.CredentialCache.DefaultCredentials"/> are sent with requests.
        /// </summary>
        /// 
        /// <returns>
        /// true if the default credentials are used{ throw new NotImplementedException();} otherwise false. The default value is false.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="USERNAME"/></PermissionSet>
        bool UseDefaultCredentials { get; set; }

        /// <summary>
        /// Gets or sets a collection of header name/value pairs associated with the request.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Net.WebHeaderCollection"/> containing header name/value pairs associated with this request.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        WebHeaderCollection Headers { get; set; }

        /// <summary>
        /// Gets or sets a collection of query name/value pairs associated with the request.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Collections.Specialized.NameValueCollection"/> that contains query name/value pairs associated with the request. If no pairs are associated with the request, the value is an empty <see cref="T:System.Collections.Specialized.NameValueCollection"/>.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode"/></PermissionSet>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        NameValueCollection QueryString { get; set; }

        /// <summary>
        /// Gets a collection of header name/value pairs associated with the response.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Net.WebHeaderCollection"/> containing header name/value pairs associated with the response, or null if no response has been received.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/></PermissionSet>
        WebHeaderCollection ResponseHeaders { get; }

        /// <summary>
        /// Gets or sets the proxy used by this <see cref="T:System.Net.WebClient"/> object.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Net.IWebProxy"/> instance used to send requests.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException"><see cref="P:System.Net.WebClient.Proxy"/> is set to null. </exception>
        IWebProxy Proxy { get; set; }

        /// <summary>
        /// Gets or sets the application's cache policy for any resources obtained by this WebClient instance using <see cref="T:System.Net.WebRequest"/> objects.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Net.Cache.RequestCachePolicy"/> object that represents the application's caching requirements.
        /// </returns>
        RequestCachePolicy CachePolicy { get; set; }

        /// <summary>
        /// Gets whether a Web request is in progress.
        /// </summary>
        /// 
        /// <returns>
        /// true if the Web request is still in progress{ throw new NotImplementedException();} otherwise false.
        /// </returns>
        bool IsBusy { get; }

        /// <summary>
        /// Occurs when an asynchronous operation to open a stream containing a resource completes.
        /// </summary>
        event OpenReadCompletedEventHandler OpenReadCompleted;

        /// <summary>
        /// Occurs when an asynchronous operation to open a stream to write data to a resource completes.
        /// </summary>
        event OpenWriteCompletedEventHandler OpenWriteCompleted;

        /// <summary>
        /// Occurs when an asynchronous resource-download operation completes.
        /// </summary>
        event DownloadStringCompletedEventHandler DownloadStringCompleted;

        /// <summary>
        /// Occurs when an asynchronous data download operation completes.
        /// </summary>
        event DownloadDataCompletedEventHandler DownloadDataCompleted;

        /// <summary>
        /// Occurs when an asynchronous file download operation completes.
        /// </summary>
        event AsyncCompletedEventHandler DownloadFileCompleted;

        /// <summary>
        /// Occurs when an asynchronous string-upload operation completes.
        /// </summary>
        event UploadStringCompletedEventHandler UploadStringCompleted;

        /// <summary>
        /// Occurs when an asynchronous data-upload operation completes.
        /// </summary>
        event UploadDataCompletedEventHandler UploadDataCompleted;

        /// <summary>
        /// Occurs when an asynchronous file-upload operation completes.
        /// </summary>
        event UploadFileCompletedEventHandler UploadFileCompleted;

        /// <summary>
        /// Occurs when an asynchronous upload of a name/value collection completes.
        /// </summary>
        event UploadValuesCompletedEventHandler UploadValuesCompleted;

        /// <summary>
        /// Occurs when an asynchronous download operation successfully transfers some or all of the data.
        /// </summary>
        event DownloadProgressChangedEventHandler DownloadProgressChanged;

        /// <summary>
        /// Occurs when an asynchronous upload operation successfully transfers some or all of the data.
        /// </summary>
        event UploadProgressChangedEventHandler UploadProgressChanged;
    }
}