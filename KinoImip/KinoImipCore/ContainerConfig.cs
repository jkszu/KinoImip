using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoImipCore
{
    class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            return builder.Build();
        }
    }
}
