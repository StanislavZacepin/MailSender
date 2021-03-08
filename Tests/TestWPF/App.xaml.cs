using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WpfMailSender.ViewModels;
using WpfMailSender.Infastructure;
using WpfMailSender.Infastructure.Services;
using MailSender.lib.Interfaces;
using MailSender.lib.Service;
using WpfMailSender.Infastructure.Services.InMemory;
using WpfMailSender.Models;
using MailSender.lib;
using Microsoft.EntityFrameworkCore;
using WpfMailSender.Data;
using WpfMailSender.Infastructure.Services.InDatabase;
using System.Windows;

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
            services.AddDbContext<MailSenderDb>(opt => opt.UseSqlServer(host.Configuration.GetConnectionString("SqlServer")));
            services.AddTransient<DbInitializer>();

            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<StatisticViemModel>();

            //services.AddSingleton<IRepository<Server>, ServersRepository>();
            //services.AddSingleton<IRepository<Sender>, SendersRepository>();
            //services.AddSingleton<IRepository<Recipient>, RecipientsRepository>();
            //services.AddSingleton<IRepository<Message>, MessagesRepository>();

            //services.AddScoped<IRepository<Server>, DbRepository<Server>>();
            //services.AddScoped<IRepository<Sender>, DbRepository<Sender>>();
            //services.AddScoped<IRepository<Recipient>, DbRepository<Recipient>>();
            //services.AddScoped<IRepository<Message>, DbRepository<Message>>();
            //services.AddScoped<IRepository<SchedulerTask>, DbRepository<SchedulerTask>>();
            services.AddScoped(typeof(IRepository<>), typeof(DbRepository<>));

            services.AddSingleton<IStatistic, InMermoryStatisticService>();

#if DEBUG
            services.AddSingleton<IMailService, DebugMailService>();
#else
            services.AddSingleton<IMailService, SmtpMailService>();
#endif
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            using (var scope = Services.CreateScope())
            {
                var initializer = scope.ServiceProvider.GetRequiredService<DbInitializer>();
                initializer.InitializeAsync().Wait();
            }

            base.OnStartup(e);
        }
    }
}
