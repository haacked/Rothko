using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace Rothko
{
    public sealed class HttpListenerWrapper : IHttpListener
    {
        readonly HttpListener inner;

        public HttpListenerWrapper(HttpListener inner)
        {
            this.inner = inner;
        }

        public AuthenticationSchemes AuthenticationSchemes
        {
            get { return inner.AuthenticationSchemes; }
            set { inner.AuthenticationSchemes = value; }
        }

        public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
        {
            get { return inner.AuthenticationSchemeSelectorDelegate; }
            set { inner.AuthenticationSchemeSelectorDelegate = value; }
        }

        public ServiceNameCollection DefaultServiceNames => inner.DefaultServiceNames;

        public ExtendedProtectionPolicy ExtendedProtectionPolicy
        {
            get { return inner.ExtendedProtectionPolicy; }
            set { inner.ExtendedProtectionPolicy = value; }
        }

        public HttpListener.ExtendedProtectionSelector ExtendedProtectionSelectorDelegate
        {
            get { return inner.ExtendedProtectionSelectorDelegate; }
            set { inner.ExtendedProtectionSelectorDelegate = value; }
        }

        public bool IgnoreWriteExceptions
        {
            get { return inner.IgnoreWriteExceptions; }
            set { inner.IgnoreWriteExceptions = value; }
        }

        public bool IsListening => inner.IsListening;

        public ICollection<string> Prefixes => inner.Prefixes;

        public string Realm
        {
            get { return inner.Realm; }
            set { inner.Realm = value; }
        }

        public HttpListenerTimeoutManager TimeoutManager => inner.TimeoutManager;

        public bool UnsafeConnectionNtlmAuthentication
        {
            get { return inner.UnsafeConnectionNtlmAuthentication; }
            set { inner.UnsafeConnectionNtlmAuthentication = value; }
        }

        public void Abort() => inner.Abort();
        public IAsyncResult BeginGetContext(AsyncCallback callback, object state) => inner.BeginGetContext(callback, state);
        public void Close() => inner.Close();
        public IHttpListenerContext EndGetContext(IAsyncResult asyncResult)
        {
            return new HttpListenerContextWrapper(inner.EndGetContext(asyncResult));
        }

        public IHttpListenerContext GetContext()
        {
            return new HttpListenerContextWrapper(inner.GetContext());
        }

        public async Task<IHttpListenerContext> GetContextAsync()
        {
            return new HttpListenerContextWrapper(await inner.GetContextAsync());
        }

        public void Start() => inner.Start();
        public void Stop() => inner.Stop();
    }
}
