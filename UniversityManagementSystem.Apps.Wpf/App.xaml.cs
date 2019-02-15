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
            containerRegistry.RegisterSingleton<IAssignmentFactService, AssignmentFactService>();
            containerRegistry.RegisterSingleton<IBookFactService, BookFactService>();
            containerRegistry.RegisterSingleton<IGraduationFactService, GraduationFactService>();
            containerRegistry.RegisterSingleton<IHallFactService, HallFactService>();
            containerRegistry.RegisterSingleton<ILectureFactService, LectureFactService>();
            containerRegistry.RegisterSingleton<ILibraryFactService, LibraryFactService>();
            containerRegistry.RegisterSingleton<IModuleFactService, ModuleFactService>();
            containerRegistry.RegisterSingleton<IRentalFactService, RentalFactService>();
            containerRegistry.RegisterSingleton<IRoomFactService, RoomFactService>();
            containerRegistry.RegisterSingleton<IStudentFactService, StudentFactService>();
            containerRegistry.RegisterSingleton<IUserService, UserService>();

            containerRegistry.Register<IMainWindowViewModel, MainWindowViewModel>();
        }
    }
}