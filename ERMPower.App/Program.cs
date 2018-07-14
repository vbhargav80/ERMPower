using System;
using Autofac;
using ERMPower.BusinessLogic;
using ERMPower.Data;

namespace ERMPower.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}