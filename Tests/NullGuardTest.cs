#if !DEBUG
using System;
using Rothko;
#endif
using Xunit;
using Environment = Rothko.Environment;

namespace Tests
{
    public class NullGuardTest
    {
        [Fact]
        public void MakeSureNullGuardIsWorking()
        {
#if !DEBUG
            Assert.Throws<ArgumentNullException>(() => new FileInfo(null));
#endif
        }

        [Fact]
        public void CheckOSVersionImplementation()
        {
            var environment = new Environment();

            Assert.NotNull(environment.OSVersion.Edition);
            Assert.NotNull(environment.OSVersion.Name);
            Assert.True(environment.OSVersion.ToString().Length > 7);
        }
    }
}
