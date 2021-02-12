using System;
using System.IO;
using System.Windows;
using WPF_GUI_04.DataLayer;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WPF_GUI_04
{
    /// <summary>
    /// Starts the application. Good luck.
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost host;

        public App()
        {
            string[] args = Environment.GetCommandLineArgs();

            this.host = new HostBuilder()
                //.ConfigureHostConfiguration((config) => { ; })
                .ConfigureAppConfiguration((hostingContext, config) => {

                    config.Sources.Clear();

                    config.SetBasePath(Directory.GetCurrentDirectory());

                    config.AddEnvironmentVariables();

                    IHostEnvironment env = hostingContext.HostingEnvironment;

                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);

                    // string[] args = Environment.GetCommandLineArgs();

                    config.AddCommandLine(args);

                    IConfigurationRoot configurationRoot = config.Build();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    ConfigureServices(hostContext.Configuration, services);
                })
                // .ConfigureLogging((hostContext, configLogging) => { ; })
                // .UseConsoleLifetime()
                .Build();
        }

        private void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            //services.AddOptions();

            string connectionString = configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
            services.AddDbContext<DBContext>(options => options.UseSqlServer(connectionString));

            // services.AddSingleton<IConfiguration>(configuration);

            services.AddSingleton<MainWindow>();

            // services.AddTransient<MainManager, MainManager>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = this.host.Services.GetService<MainWindow>();
            mainWindow.Show();

            // base.OnStartup(e);
        }
        //protected override async void OnStartup(StartupEventArgs e)

        protected override async void OnExit(ExitEventArgs e)
        {
            using (this.host) await this.host.StopAsync();

            base.OnExit(e);
        }
















        /*
        public IConfiguration Configuration { get; }

        var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        .AddEnvironmentVariables();
        Configuration = builder.Build();


        .ConfigureHostConfiguration((config) => {

            config.SetBasePath(Directory.GetCurrentDirectory());
            config.AddJsonFile("hostsettings.json", optional: true);
            config.AddEnvironmentVariables(prefix: "FUZZBIZZ_");
            config.AddCommandLine(args);
        })

        .ConfigureLogging((hostingContext, logging) => {
            logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
            logging.AddConsole();
        })

        this.host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
            this.ConfigureServices(context, services);
        })
            .Build();

        private void BuildHostConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();
            foreach (var buildAction in _configureHostConfigActions)
            {
                buildAction(configBuilder);
            }
            _hostConfiguration = configBuilder.Build();
        }

        static async Task Main(string[] args)
        {

            IConfiguration Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
        }
        */

        //////////////////////////////////////////////////////////////////////////////
        ///https://docs.microsoft.com/en-us/dotnet/core/extensions/configuration-providers
        ///https://www.thecodebuzz.com/dependency-injection-wpf-generic-hostbuilder-net-core/
        ///https://github.com/dotnet/aspnetcore/blob/1c3fa82908fe2cb773626b6613843213286a482b/src/Microsoft.Extensions.Hosting/HostBuilder.cs
        ///https://www.stevejgordon.co.uk/using-generic-host-in-dotnet-core-console-based-microservices
        //////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////

        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    Window window = new MainWindow();
        //    window.DataContext = new MainWindow();
        //    window.Show();

        //    base.OnStartup(e);
        //}

        /*
         private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
         {
             string connectionString = context.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;

             services.AddDbContext<DBContext>(options => options.UseSqlServer(connectionString));

             services.AddSingleton<IConfiguration>(context.Configuration);

             services.AddSingleton<MainWindow>();
         }

         protected override async void OnStartup(StartupEventArgs e)
         {
             await this.host.StartAsync();

             // Hier wird das Hauptfenster gestartet.
             // Aus diesem Grunde wurde in der Datei App.xaml StartupUri="MainWindow.xaml" entfernt.
             //var mainWindow = this.host.Services.GetRequiredService<MainWindow>();
             //mainWindow.Show();

             base.OnStartup(e);
         }

         protected override async void OnExit(ExitEventArgs e)
         {
             using (this.host)
             {
                 await this.host.StartAsync();
             }

             base.OnExit(e);
         }
         */
    }
}