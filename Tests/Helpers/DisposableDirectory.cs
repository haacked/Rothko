using System;
using System.IO;

public sealed class DisposableDirectory : IDisposable
{
    readonly DirectoryInfo directory;

    public static DisposableDirectory CreateRandomDirectory()
    {
        return CreateDirectory(GetRandomRothkoTemporaryFolder());
    }

    public static DisposableDirectory CreateDirectory(string path)
    {
        return new DisposableDirectory(new DirectoryInfo(path));
    }

    DisposableDirectory(DirectoryInfo directory)
    {
        this.directory = directory;
    }

    public string FullPath { get { return directory.FullName; } }

    public void Dispose()
    {
        directory.Delete(true);
    }

    static string GetRandomRothkoTemporaryFolder()
    {
        return Path.Combine(Path.GetTempPath(), "__RothkoTestFolder-REMOVE-ME", Path.GetRandomFileName());
    }
}
