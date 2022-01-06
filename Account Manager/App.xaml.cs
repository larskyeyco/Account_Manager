using Account_Manager.Services;
using Autofac;
using System.Windows;

namespace Account_Manager
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>();
            builder.RegisterType<LeagueEntryService>();
            builder.RegisterType<SummonerService>();

            var container = builder.Build();

            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
