using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rothko.Infrastructure;

namespace Rothko
{
    /// <summary>
    /// Every DI container in the world has its own way of registering instances. This provides a dictionary of types
    /// and implementations of those types for the various facade and factory classes. This should make it easy to
    /// register all the useful services in this library.
    /// </summary>
    public static class DependencyRegistrationHelper
    {
        private static readonly IReadOnlyDictionary<Type, DependencyInfo> _dependencies = CreateDependencyDictionary();

        public static IReadOnlyDictionary<Type, DependencyInfo> RothkoDependencies 
        {
            get
            {
                return _dependencies;
            }
        }

        private static ReadOnlyDictionary<Type, DependencyInfo> CreateDependencyDictionary()
        {
            var operatingSystemFacade = new OperatingSystemFacade();

            var dependencies = new Dictionary<Type, DependencyInfo>();
            dependencies.Add<IOperatingSystem>(operatingSystemFacade); 
            dependencies.Add(operatingSystemFacade.Assembly);
            dependencies.Add(operatingSystemFacade.Environment);
            dependencies.Add(operatingSystemFacade.Dialog); 
            dependencies.Add(operatingSystemFacade.File);
            dependencies.Add(operatingSystemFacade.MemoryMappedFiles);
            dependencies.Add(operatingSystemFacade.ProcessLocator);
            dependencies.Add(operatingSystemFacade.ProcessStarter);
            dependencies.Add(operatingSystemFacade.Registry);
            
            return new ReadOnlyDictionary<Type, DependencyInfo>(dependencies);
        }

        static void Add<TInterface>(this IDictionary<Type, DependencyInfo> dictionary, TInterface instance)
        {
            dictionary.Add(typeof(TInterface), new DependencyInfo(instance.GetType(), () => instance));
        }
    }

    public class DependencyInfo
    {
        public DependencyInfo(Type type, Func<object> factory)
        {
            ConcreteType = type;
            Factory = factory;
        }

        public Type ConcreteType { get; private set; }
        public Func<object> Factory { get; private set; }
    }
}
