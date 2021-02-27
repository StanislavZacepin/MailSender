using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WpfMailSender.ViewModels;
using WpfMailSender.Infastructure;
using WpfMailSender.Infastructure.Services;
using MailSender.lib.Interfaces;
using MailSender.lib.Service;

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private static IHost _Hosting;

        public static IHost Hosting => _Hosting
            ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
        public static IServiceProvider Services => Hosting.Services;

            public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(opt => opt.AddJsonFile("appsettings.json",false,true))
            .ConfigureServices(ConfigureServices);

        private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<StatisticViemModel>();

            services.AddSingleton<ServersRepository>();
            services.AddSingleton<IStatistic, InMermoryStatisticService>();
            services.AddSingleton<IMailService, DebugMailService>();
        }
    }
}
