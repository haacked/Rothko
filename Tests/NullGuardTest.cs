#if !DEBUG
using System;
#endif
using Rothko;
using Xunit;
using Xunit.Sdk;

namespace Tests
{
    public class NullGuardTest
    {
        [Fact]
        public void MakeSureNullGuardIsWorking()
        {
#if DEBUG
            Assert.Throws<TraceAssertException>(() => new FileInfo(null));
#else
            Assert.Throws<ArgumentNullException>(() => new FileInfo(null));
#endif
        }

        [Fact]
        public void CheckOSVersionImplementation()
        {
            Environment env = new Environment();

            Assert.NotNull(env.OSVersion.Edition);
            Assert.NotNull(env.OSVersion.Name);
            Assert.True(env.OSVersion.ToString().Length > 7);
        }
    }
}
