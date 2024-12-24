// ComicReader.WPF/App.xaml.cs
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using ComicReader.ViewModels; // Assuming MainViewModel is in ComicReader.ViewModels

namespace ComicReader.WPF
{
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainViewModel>();
            // Add other services here
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}