using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Env = System.Environment;

namespace Rothko
{
    public interface IEnvironment
    {
        string CommandLine { get; }

        string CurrentDirectory { get; set; }

        int ExitCode { get; set; }

        bool HasShutdownStarted { get; }

        bool Is64BitOperatingSystem { get; }

        bool Is64BitProcess { get; }

        string MachineName { get; }

        string NewLine { get; }

        IOperatingSystem OSVersion { get; }

        int ProcessorCount { get; }

        string StackTrace { get; }

        string SystemDirectory { get; }

        int SystemPageSize { get; }

        int TickCount { get; }

        string UserDomainName { get; }

        bool UserInteractive { get; }

        string UserName { get; }

        Version Version { get; }

        long WorkingSet { get; }

        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Exit",
            Justification = "Hey, I didn't name this method. That's what the original is named.")]
        void Exit(int exitCode);

        string ExpandEnvironmentVariables(string name);

        void FailFast(string message);

        void FailFast(string message, Exception exception);

        IReadOnlyList<string> GetCommandLineArgs();

        string GetEnvironmentVariable(string variable);

        string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target);

        IDictionary<string, string> GetEnvironmentVariables();

        IDictionary<string, string> GetEnvironmentVariables(EnvironmentVariableTarget target);

        string GetFolderPath(Env.SpecialFolder folder);

        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Option",
            Justification = "Hey, I didn't name this method. That's what the original is named.")]
        string GetFolderPath(Env.SpecialFolder folder, Env.SpecialFolderOption option);

        IReadOnlyList<string> GetLogicalDrives();

        void SetEnvironmentVariable(string variable, string value);

        void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target);
    }
}