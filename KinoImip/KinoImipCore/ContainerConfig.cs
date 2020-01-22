using Autofac;
using System.Linq;
using System.Reflection;

namespace KinoImipCore
{
    class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(KinoImipLibrary)))
                .Where(t => t.Namespace.Contains("Interfaces"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
