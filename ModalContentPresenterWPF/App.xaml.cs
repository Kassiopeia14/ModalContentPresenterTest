using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModalContentPresenterWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ModalContentPresenterWPF
{
    public partial class App : Application
    {
        private IHostBuilder hostBuilder;
        public IHost ProgramHost { get; set; }

        public App()
        {
            hostBuilder = Host
                .CreateDefaultBuilder()
                .ConfigureServices(PrepareServices);
        } 

        public void PrepareServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddSingleton<MainVM>();

            services.AddSingleton<FirstVM>();
            services.AddSingleton<SecondVM>();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ProgramHost = hostBuilder.Build();
            ProgramHost.Start();
        }
    }
}
