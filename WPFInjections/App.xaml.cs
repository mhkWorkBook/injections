using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using NetCore.AutoRegisterDi;
using WPFInjections.Implemtations;
using WPFInjections.Interfaces;
using WPFInjections.ViewModels;

namespace WPFInjections
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ServiceCollection services = new ServiceCollection();

            string country = "DK";
            bool autoAdd = true;
            if (autoAdd)
            {
                switch (country)
                {
                    case "DK":
                        services.ConfigureServices(typeof(IDKLogicService));
                        break;
                    case "US":
                        services.ConfigureServices(typeof(IUSLogicService));
                        break;
                    case "EU":
                        services.ConfigureServices(typeof(IEULogicService));
                        break;
                    case "GB":
                        services.ConfigureServices(typeof(IGBLogicService));
                        break;
                }
            }
            else
            {
                switch (country)
                {
                    case "DK":
                        services.AddSingleton<IWriteJson, DKWriteJson>();
                        services.AddSingleton<IReadJson, DKReadJson>();
                        break;
                    case "US":
                        services.AddSingleton<IWriteJson, USWriteJson>();
                        services.AddSingleton<IReadJson, USReadJson>();
                        break;
                    case "EU":
                        services.AddSingleton<IWriteJson, EUWriteJson>();
                        services.AddSingleton<IReadJson, EUReadJson>();
                        break;
                    case "GB":
                        services.AddSingleton<IWriteJson, GBWriteJson>();
                        services.AddSingleton<IReadJson, GBReadJson>();
                        break;

                }
            }

            services.AddSingleton<MainWindowViewModel>();

            ServiceProvider = services.BuildServiceProvider();            
        }

        public static ServiceProvider ServiceProvider { get; private set; }
    }

    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, Type type)
        {
            var serviceAssembly = Assembly.GetAssembly(type);

            services.RegisterAssemblyPublicNonGenericClasses(serviceAssembly)
              .Where(c => c.GetInterfaces().Contains(type))
              .AsPublicImplementedInterfaces();

            return services;
        }

    }
}
