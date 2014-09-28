using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Rothko
{
    public class WebClient : IWebClient
    {
        private readonly System.Net.WebClient innerWebClient;

        public WebClient()
        {
            innerWebClient = new System.Net.WebClient();

            HookEvents();
        }

        public byte[] DownloadData(string address)
        {
            return innerWebClient.DownloadData(address);
        }

        public byte[] DownloadData(Uri address)
        {
            return innerWebClient.DownloadData(address);
        }

        public void DownloadFile(string address, string fileName)
        {
            innerWebClient.DownloadFile(address, fileName);
        }

        public void DownloadFile(Uri address, string fileName)
        {
            innerWebClient.DownloadFile(address, fileName);
        }

        public System.IO.Stream OpenRead(string address)
        {
            return innerWebClient.OpenRead(address);
        }

        public System.IO.Stream OpenRead(Uri address)
        {
            return innerWebClient.OpenRead(address);
        }

        public System.IO.Stream OpenWrite(string address)
        {
            return innerWebClient.OpenWrite(address);
        }

        public System.IO.Stream OpenWrite(Uri address)
        {
            return innerWebClient.OpenWrite(address);
        }

        public System.IO.Stream OpenWrite(string address, string method)
        {
            return innerWebClient.OpenWrite(address, method);
        }

        public System.IO.Stream OpenWrite(Uri address, string method)
        {
            return innerWebClient.OpenWrite(address, method);
        }

        public byte[] UploadData(string address, byte[] data)
        {
            return innerWebClient.UploadData(address, data);
        }

        public byte[] UploadData(Uri address, byte[] data)
        {
            return innerWebClient.UploadData(address, data);
        }

        public byte[] UploadData(string address, string method, byte[] data)
        {
            return innerWebClient.UploadData(address, method, data);
        }

        public byte[] UploadData(Uri address, string method, byte[] data)
        {
            return innerWebClient.UploadData(address, method, data);
        }

        public byte[] UploadFile(string address, string fileName)
        {
            return innerWebClient.UploadFile(address, fileName);
        }

        public byte[] UploadFile(Uri address, string fileName)
        {
            return innerWebClient.UploadFile(address, fileName);
        }

        public byte[] UploadFile(string address, string method, string fileName)
        {
            return innerWebClient.UploadFile(address, method, fileName);
        }

        public byte[] UploadFile(Uri address, string method, string fileName)
        {
            return innerWebClient.UploadFile(address, method, fileName);
        }

        public byte[] UploadValues(string address, NameValueCollection data)
        {
            return innerWebClient.UploadValues(address, data);
        }

        public byte[] UploadValues(Uri address, NameValueCollection data)
        {
            return innerWebClient.UploadValues(address, data);
        }

        public byte[] UploadValues(string address, string method, NameValueCollection data)
        {
            return innerWebClient.UploadValues(address, method, data);
        }

        public byte[] UploadValues(Uri address, string method, NameValueCollection data)
        {
            return innerWebClient.UploadValues(address, method, data);
        }

        public string UploadString(string address, string data)
        {
            return innerWebClient.UploadString(address, data);
        }

        public string UploadString(Uri address, string data)
        {
            return innerWebClient.UploadString(address, data);
        }

        public string UploadString(string address, string method, string data)
        {
            return innerWebClient.UploadString(address, method, data);
        }

        public string UploadString(Uri address, string method, string data)
        {
            return innerWebClient.UploadString(address, method, data);
        }

        public string DownloadString(string address)
        {
            return innerWebClient.DownloadString(address);
        }

        public string DownloadString(Uri address)
        {
            return innerWebClient.DownloadString(address);
        }

        public void OpenReadAsync(Uri address)
        {
            innerWebClient.OpenReadAsync(address);
        }

        public void OpenReadAsync(Uri address, object userToken)
        {
            innerWebClient.OpenReadAsync(address, userToken);
        }

        public void OpenWriteAsync(Uri address)
        {
            innerWebClient.OpenWriteAsync(address);
        }

        public void OpenWriteAsync(Uri address, string method)
        {
            innerWebClient.OpenWriteAsync(address, method);
        }

        public void OpenWriteAsync(Uri address, string method, object userToken)
        {
            innerWebClient.OpenWriteAsync(address, method, userToken);
        }

        public void DownloadStringAsync(Uri address)
        {
            innerWebClient.DownloadStringAsync(address);
        }

        public void DownloadStringAsync(Uri address, object userToken)
        {
            innerWebClient.DownloadStringAsync(address, userToken);
        }

        public void DownloadDataAsync(Uri address)
        {
            innerWebClient.DownloadDataAsync(address);
        }

        public void DownloadDataAsync(Uri address, object userToken)
        {
            innerWebClient.DownloadDataAsync(address, userToken);
        }

        public void DownloadFileAsync(Uri address, string fileName)
        {
            innerWebClient.DownloadFileAsync(address, fileName);
        }

        public void DownloadFileAsync(Uri address, string fileName, object userToken)
        {
            innerWebClient.DownloadFileAsync(address, fileName, userToken);
        }

        public void UploadStringAsync(Uri address, string data)
        {
            innerWebClient.UploadStringAsync(address, data);
        }

        public void UploadStringAsync(Uri address, string method, string data)
        {
            innerWebClient.UploadStringAsync(address, method, data);
        }

        public void UploadStringAsync(Uri address, string method, string data, object userToken)
        {
            innerWebClient.UploadStringAsync(address, method, data, userToken);
        }

        public void UploadDataAsync(Uri address, byte[] data)
        {
            innerWebClient.UploadDataAsync(address, data);
        }

        public void UploadDataAsync(Uri address, string method, byte[] data)
        {
            innerWebClient.UploadDataAsync(address, method, data);
        }

        public void UploadDataAsync(Uri address, string method, byte[] data, object userToken)
        {
            innerWebClient.UploadDataAsync(address, method, data, userToken);
        }

        public void UploadFileAsync(Uri address, string fileName)
        {
            innerWebClient.UploadFileAsync(address, fileName);
        }

        public void UploadFileAsync(Uri address, string method, string fileName)
        {
            innerWebClient.UploadFileAsync(address, method, fileName);
        }

        public void UploadFileAsync(Uri address, string method, string fileName, object userToken)
        {
            innerWebClient.UploadFileAsync(address, method, fileName, userToken);
        }

        public void UploadValuesAsync(Uri address, NameValueCollection data)
        {
            innerWebClient.UploadValuesAsync(address, data);
        }

        public void UploadValuesAsync(Uri address, string method, NameValueCollection data)
        {
            innerWebClient.UploadValuesAsync(address, method, data);
        }

        public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken)
        {
            innerWebClient.UploadValuesAsync(address, method, data, userToken);
        }

        public void CancelAsync()
        {
            innerWebClient.CancelAsync();
        }

        public Task DownloadStringTaskAsync(string address)
        {
            return innerWebClient.DownloadStringTaskAsync(address);
        }

        public Task DownloadStringTaskAsync(Uri address)
        {
            return innerWebClient.DownloadStringTaskAsync(address);
        }

        public Task OpenReadTaskAsync(string address)
        {
            return innerWebClient.OpenReadTaskAsync(address);
        }

        public Task OpenReadTaskAsync(Uri address)
        {
            return innerWebClient.OpenReadTaskAsync(address);
        }

        public Task OpenWriteTaskAsync(string address)
        {
            return innerWebClient.OpenWriteTaskAsync(address);
        }

        public Task OpenWriteTaskAsync(Uri address)
        {
            return innerWebClient.OpenWriteTaskAsync(address);
        }

        public Task OpenWriteTaskAsync(string address, string method)
        {
            return innerWebClient.OpenWriteTaskAsync(address, method);
        }

        public Task OpenWriteTaskAsync(Uri address, string method)
        {
            return innerWebClient.OpenWriteTaskAsync(address, method);
        }

        public Task UploadStringTaskAsync(string address, string data)
        {
            return innerWebClient.UploadStringTaskAsync(address, data);
        }

        public Task UploadStringTaskAsync(Uri address, string data)
        {
            return innerWebClient.UploadStringTaskAsync(address, data);
        }

        public Task UploadStringTaskAsync(string address, string method, string data)
        {
            return innerWebClient.UploadStringTaskAsync(address, method, data);
        }

        public Task UploadStringTaskAsync(Uri address, string method, string data)
        {
            return innerWebClient.UploadStringTaskAsync(address, method, data);
        }

        public Task DownloadDataTaskAsync(string address)
        {
            return innerWebClient.DownloadDataTaskAsync(address);
        }

        public Task DownloadDataTaskAsync(Uri address)
        {
            return innerWebClient.DownloadDataTaskAsync(address);
        }

        public Task DownloadFileTaskAsync(string address, string fileName)
        {
            return innerWebClient.DownloadFileTaskAsync(address, fileName);
        }

        public Task DownloadFileTaskAsync(Uri address, string fileName)
        {
            return innerWebClient.DownloadFileTaskAsync(address, fileName);
        }

        public Task UploadDataTaskAsync(string address, byte[] data)
        {
            return innerWebClient.UploadDataTaskAsync(address, data);
        }

        public Task UploadDataTaskAsync(Uri address, byte[] data)
        {
            return innerWebClient.UploadDataTaskAsync(address, data);
        }

        public Task UploadDataTaskAsync(string address, string method, byte[] data)
        {
            return innerWebClient.UploadDataTaskAsync(address, method, data);
        }

        public Task UploadDataTaskAsync(Uri address, string method, byte[] data)
        {
            return innerWebClient.UploadDataTaskAsync(address, method, data);
        }

        public Task UploadFileTaskAsync(string address, string fileName)
        {
            return innerWebClient.UploadFileTaskAsync(address, fileName);
        }

        public Task UploadFileTaskAsync(Uri address, string fileName)
        {
            return innerWebClient.UploadFileTaskAsync(address, fileName);
        }

        public Task UploadFileTaskAsync(string address, string method, string fileName)
        {
            return innerWebClient.UploadFileTaskAsync(address, method, fileName);
        }

        public Task UploadFileTaskAsync(Uri address, string method, string fileName)
        {
            return innerWebClient.UploadFileTaskAsync(address, method, fileName);
        }

        public Task UploadValuesTaskAsync(string address, NameValueCollection data)
        {
            return innerWebClient.UploadValuesTaskAsync(address, data);
        }

        public Task UploadValuesTaskAsync(string address, string method, NameValueCollection data)
        {
            return innerWebClient.UploadValuesTaskAsync(address, method, data);
        }

        public Task UploadValuesTaskAsync(Uri address, NameValueCollection data)
        {
            return innerWebClient.UploadValuesTaskAsync(address, data);
        }
        public Task UploadValuesTaskAsync(Uri address, string method, NameValueCollection data)
        {
            return innerWebClient.UploadValuesTaskAsync(address, method, data);
        }

        public Encoding Encoding
        {
            get { return innerWebClient.Encoding; }
            set { innerWebClient.Encoding = value; }
        }

        public string BaseAddress
        {
            get { return innerWebClient.BaseAddress; }
            set { innerWebClient.BaseAddress = value; }
        }

        public ICredentials Credentials
        {
            get { return innerWebClient.Credentials; }
            set { innerWebClient.Credentials = value; }
        }

        public bool UseDefaultCredentials
        {
            get { return innerWebClient.UseDefaultCredentials; }
            set { innerWebClient.UseDefaultCredentials = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public WebHeaderCollection Headers
        {
            get { return innerWebClient.Headers; }
            set { innerWebClient.Headers = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public NameValueCollection QueryString
        {
            get { return innerWebClient.QueryString; }
            set { innerWebClient.QueryString = value; }
        }

        public WebHeaderCollection ResponseHeaders
        {
            get { return innerWebClient.ResponseHeaders; }
        }

        public IWebProxy Proxy
        {
            get { return innerWebClient.Proxy; }
            set { innerWebClient.Proxy = value; }
        }

        public RequestCachePolicy CachePolicy
        {
            get { return innerWebClient.CachePolicy; }
            set { innerWebClient.CachePolicy = value; }
        }

        public bool IsBusy
        {
            get { return innerWebClient.IsBusy; }
        }

        private void HookEvents()
        {
            innerWebClient.OpenReadCompleted += OnOpenReadCompleted;
            innerWebClient.OpenWriteCompleted += OnOpenWriteCompleted;

            innerWebClient.DownloadDataCompleted += DownloadDataCompleted;
            innerWebClient.DownloadFileCompleted += DownloadFileCompleted;
            innerWebClient.DownloadStringCompleted += DownloadStringCompleted;
            innerWebClient.UploadDataCompleted += UploadDataCompleted;
            innerWebClient.UploadFileCompleted += UploadFileCompleted;
            innerWebClient.UploadStringCompleted += UploadStringCompleted;
            innerWebClient.UploadValuesCompleted += UploadValuesCompleted;

            innerWebClient.DownloadProgressChanged += DownloadProgressChanged;            
            innerWebClient.UploadProgressChanged += UploadProgressChanged;
        }

        private void UnhookEvents()
        {
            innerWebClient.OpenReadCompleted -= OnOpenReadCompleted;
            innerWebClient.OpenWriteCompleted -= OnOpenWriteCompleted;

            innerWebClient.DownloadDataCompleted -= DownloadDataCompleted;
            innerWebClient.DownloadFileCompleted -= DownloadFileCompleted;
            innerWebClient.DownloadStringCompleted -= DownloadStringCompleted;
            innerWebClient.UploadDataCompleted -= UploadDataCompleted;
            innerWebClient.UploadFileCompleted -= UploadFileCompleted;
            innerWebClient.UploadStringCompleted -= UploadStringCompleted;
            innerWebClient.UploadValuesCompleted -= UploadValuesCompleted;

            innerWebClient.DownloadProgressChanged -= DownloadProgressChanged;
            innerWebClient.UploadProgressChanged -= UploadProgressChanged;
        }

        public event OpenReadCompletedEventHandler OpenReadCompleted;
        public event OpenWriteCompletedEventHandler OpenWriteCompleted;
        public event DownloadStringCompletedEventHandler DownloadStringCompleted;
        public event DownloadDataCompletedEventHandler DownloadDataCompleted;
        public event DownloadProgressChangedEventHandler DownloadProgressChanged;
        public event AsyncCompletedEventHandler DownloadFileCompleted;
        public event UploadStringCompletedEventHandler UploadStringCompleted;
        public event UploadDataCompletedEventHandler UploadDataCompleted;
        public event UploadFileCompletedEventHandler UploadFileCompleted;
        public event UploadValuesCompletedEventHandler UploadValuesCompleted;
        public event UploadProgressChangedEventHandler UploadProgressChanged;

        #region Event Invocators
        protected virtual void OnOpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            OpenReadCompletedEventHandler handler = OpenReadCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnOpenWriteCompleted(object sender, OpenWriteCompletedEventArgs e)
        {
            OpenWriteCompletedEventHandler handler = OpenWriteCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            DownloadStringCompletedEventHandler handler = DownloadStringCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnDownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            DownloadDataCompletedEventHandler handler = DownloadDataCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            AsyncCompletedEventHandler handler = DownloadFileCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnUploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            UploadStringCompletedEventHandler handler = UploadStringCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnUploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
        {
            UploadDataCompletedEventHandler handler = UploadDataCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnUploadFileCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            UploadFileCompletedEventHandler handler = UploadFileCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnUploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
        {
            UploadValuesCompletedEventHandler handler = UploadValuesCompleted;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgressChangedEventHandler handler = DownloadProgressChanged;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnUploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            UploadProgressChangedEventHandler handler = UploadProgressChanged;
            if (handler != null) handler(this, e);
        }
        #endregion

        /// <summary>
        ///   Releases all resources used by the <see cref="T:Rothko.WebClient"/>.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///   Releases the unmanaged resources used by the <see cref="T:Rothko.WebClient"/> and
        ///   optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        ///   true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (innerWebClient != null)
                {
                    UnhookEvents();
                    innerWebClient.Dispose();
                }
            }
        }
    }
}
