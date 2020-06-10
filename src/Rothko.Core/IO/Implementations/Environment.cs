using System;
using System.Collections.Generic;
using Rothko.Implementations;
using Env = System.Environment;

namespace Rothko.IO.Implementations
{
    public class Environment : IEnvironment
    {
        public Environment()
        {
            OSVersion = new OperatingSystemInfo();
        }

        public string CommandLine => Env.CommandLine;

        public string CurrentDirectory
        {
            get => Env.CurrentDirectory;
            set => Env.CurrentDirectory = value;
        }

        public int ExitCode
        {
            get => Env.ExitCode;
            set => Env.ExitCode = value;
        }

        public bool HasShutdownStarted => Env.HasShutdownStarted;

        public bool Is64BitOperatingSystem => Env.Is64BitOperatingSystem;

        public bool Is64BitProcess => Env.Is64BitProcess;

        public string MachineName => Env.MachineName;

        public string NewLine => Env.NewLine;

        public IOperatingSystemInfo OSVersion
        {
            get;
        }

        public int ProcessorCount => Env.ProcessorCount;

        public string StackTrace => Env.StackTrace;

        public string SystemDirectory => Env.SystemDirectory;

        public int SystemPageSize => Env.SystemPageSize;

        public int TickCount => Env.TickCount;

        public string UserDomainName => Env.UserDomainName;

        public bool UserInteractive => Env.UserInteractive;

        public string UserName => Env.UserName;

        public Version Version => Env.Version;

        public long WorkingSet => Env.WorkingSet;

        public void Exit(int exitCode)
        {
            Env.Exit(exitCode);
        }

        public string ExpandEnvironmentVariables(string name)
        {
            return Env.ExpandEnvironmentVariables(name);
        }

        public void FailFast(string message)
        {
            Env.FailFast(message);
        }

        public void FailFast(string message, Exception exception)
        {
            Env.FailFast(message, exception);
        }

        public IReadOnlyList<string> GetCommandLineArgs()
        {
            return Env.GetCommandLineArgs();
        }

        public string? GetEnvironmentVariable(string variable)
        {
            return Env.GetEnvironmentVariable(variable);
        }

        public string? GetEnvironmentVariable(string variable, EnvironmentVariableTarget target)
        {
            return Env.GetEnvironmentVariable(variable, target);
        }

        public IDictionary<string, string> GetEnvironmentVariables()
        {
            return Env.GetEnvironmentVariables().ToGenericDictionary<string, string>();
        }

        public IDictionary<string, string> GetEnvironmentVariables(EnvironmentVariableTarget target)
        {
            return Env.GetEnvironmentVariables(target).ToGenericDictionary<string, string>();
        }

        public string GetFolderPath(Env.SpecialFolder folder)
        {
            return Env.GetFolderPath(folder);
        }

        public string GetFolderPath(Env.SpecialFolder folder, Env.SpecialFolderOption option)
        {
            return Env.GetFolderPath(folder, option);
        }

        public IReadOnlyList<string> GetLogicalDrives()
        {
            return Env.GetLogicalDrives();
        }

        public void SetEnvironmentVariable(string variable, string value)
        {
            Env.SetEnvironmentVariable(variable, value);
        }

        public void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target)
        {
            Env.SetEnvironmentVariable(variable, value, target);
        }
    }
}
