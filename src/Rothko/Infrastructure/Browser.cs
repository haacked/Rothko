using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Rothko.Infrastructure
{
    public class Browser : IBrowser
    {
        readonly IProcessStarter processStarter;
        readonly IEnvironment environment;

        public Browser(IProcessStarter processStarter, IEnvironment environment)
        {
            this.processStarter = processStarter;
            this.environment = environment;
        }

        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
            Justification = "We can't anticipate the type of exception it'll throw and we want to have the fallback behavior")]
        public void OpenUrl(Uri url)
        {
            if (url.IsAbsoluteUri) throw new ArgumentException("URL must be an absolute uri", "url");

            try
            {
                processStarter.Start(url.ToString(), null);
            }
            catch (Exception firstAttemptException)
            {
                try
                {
                    var programFiles = environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles);

                    processStarter.Start(Path.Combine(programFiles, @"Internet Explorer", "iexplore.exe"),
                        url.ToString());
                }
                catch (Exception secondAttemptException)
                {
                    throw new AggregateException(firstAttemptException, secondAttemptException);
                }
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
            Justification = "By design, this method should not throw.")]
        public bool TryOpenUrl(Uri url)
        {
            try
            {
                OpenUrl(url);
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
