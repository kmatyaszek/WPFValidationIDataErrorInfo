using Autofac;
using System.Windows;
using WPFValidationIDataErrorInfo.Startup;

namespace WPFValidationIDataErrorInfo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var container = ContrainerConfig.Configure();

            var mainView = container.Resolve<MainWindow>();
            mainView.Show();
        }
    }
}
