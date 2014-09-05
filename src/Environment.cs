using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Env = System.Environment;

namespace Rothko
{
    [Export(typeof(IEnvironment))]
    public class Environment : IEnvironment
    {
        public Environment()
        {
            OSVersion = new OperatingSystem(Env.OSVersion);
        }

        public string CommandLine
        {
            get { return Env.CommandLine; }
        }

        public string CurrentDirectory
        {
            get { return Env.CurrentDirectory; }
            set { Env.CurrentDirectory = value; }
        }

        public int ExitCode
        {
            get { return Env.ExitCode; }
            set { Env.ExitCode = value; }
        }

        public bool HasShutdownStarted
        {
            get { return Env.HasShutdownStarted; }
        }

        public bool Is64BitOperatingSystem
        {
            get { return Env.Is64BitOperatingSystem; }
        }

        public bool Is64BitProcess
        {
            get { return Env.Is64BitProcess; }
        }

        public string MachineName
        {
            get { return Env.MachineName; }
        }

        public string NewLine
        {
            get { return Env.NewLine; }
        }

        public IOperatingSystem OSVersion
        {
            get; private set;
        }

        public int ProcessorCount
        {
            get { return Env.ProcessorCount; }
        }

        public string StackTrace
        {
            get { return Env.StackTrace; }
        }

        public string SystemDirectory
        {
            get { return Env.SystemDirectory; }
        }

        public int SystemPageSize
        {
            get { return Env.SystemPageSize; }
        }

        public int TickCount
        {
            get { return Env.TickCount; }
        }

        public string UserDomainName
        {
            get { return Env.UserDomainName; }
        }

        public bool UserInteractive
        {
            get { return Env.UserInteractive; }
        }

        public string UserName
        {
            get { return Env.UserName; }
        }

        public Version Version
        {
            get { return Env.Version; }
        }

        public long WorkingSet
        {
            get { return Env.WorkingSet; }
        }

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

        public string GetEnvironmentVariable(string variable)
        {
            return Env.GetEnvironmentVariable(variable);
        }

        public string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target)
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
