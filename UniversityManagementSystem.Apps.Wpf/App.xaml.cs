using System.Windows;
using Prism.Ioc;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Views;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IUserService, UserService>();

            containerRegistry.Register<IMainWindowViewModel, MainWindowViewModel>();
        }
    }
}