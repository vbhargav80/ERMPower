using Autofac;
using ERMPower.BusinessLogic;
using ERMPower.BusinessLogic.Interfaces;
using ERMPower.Data;

namespace ERMPower.App
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<FileRepository>().As<IRepository>();
            builder.RegisterType<MedianCalculator>().As<IMedianCalculator>();
            builder.RegisterType<MedianVariationService>().As<IMedianVariationService>();

            return builder.Build();
        }
    }
}
