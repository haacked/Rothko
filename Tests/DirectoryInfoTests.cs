using System.IO;
using Xunit;
using DirectoryInfo = Rothko.DirectoryInfo;

public class DirectoryInfoTests
{
    public class TheCreateMethod
    {
        [Fact]
        public void CreatesMissingParentDirectories()
        {
            using (var tempDir = DisposableDirectory.CreateRandomDirectory())
            {
                var path = Path.Combine(tempDir.FullPath, "foo", "bar", "baz");
                var directory = new DirectoryInfo(path);
                Assert.False(Directory.Exists(Path.Combine(tempDir.FullPath, "foo")));
                Assert.False(Directory.Exists(Path.Combine(tempDir.FullPath, "foo", "bar")));
                Assert.False(Directory.Exists(path));

                directory.Create();

                Assert.True(Directory.Exists(Path.Combine(tempDir.FullPath, "foo")));
                Assert.True(Directory.Exists(Path.Combine(tempDir.FullPath, "foo", "bar")));
                Assert.True(Directory.Exists(path));
            }
        }
    }
}
