using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Assignment;
using UniversityManagementSystem.Apps.Wpf.Modules.Auth;
using UniversityManagementSystem.Apps.Wpf.Modules.Book;
using UniversityManagementSystem.Apps.Wpf.Modules.Graduation;
using UniversityManagementSystem.Apps.Wpf.Modules.Home;
using UniversityManagementSystem.Apps.Wpf.Modules.Lecture;
using UniversityManagementSystem.Apps.Wpf.Modules.Library;
using UniversityManagementSystem.Apps.Wpf.Modules.Main;
using UniversityManagementSystem.Apps.Wpf.Modules.Module;
using UniversityManagementSystem.Apps.Wpf.Modules.Rental;
using UniversityManagementSystem.Apps.Wpf.Modules.Room;
using UniversityManagementSystem.Apps.Wpf.Modules.Student;
using UniversityManagementSystem.Apps.Wpf.Views;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf
{
    public partial class App
    {
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<AssignmentModule>();
            moduleCatalog.AddModule<AuthModule>();
            moduleCatalog.AddModule<BookModule>();
            moduleCatalog.AddModule<GraduationModule>();
            moduleCatalog.AddModule<HomeModule>();
            moduleCatalog.AddModule<LectureModule>();
            moduleCatalog.AddModule<LibraryModule>();
            moduleCatalog.AddModule<MainModule>();
            moduleCatalog.AddModule<ModuleModule>();
            moduleCatalog.AddModule<RentalModule>();
            moduleCatalog.AddModule<RoomModule>();
            moduleCatalog.AddModule<StudentModule>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            #region Services

            containerRegistry.RegisterSingleton<IEnrolmentService, EnrolmentService>();
            containerRegistry.RegisterSingleton<IUserService, UserService>();

            #region Dims

            containerRegistry.RegisterSingleton<IBookDimService, BookDimService>();
            containerRegistry.RegisterSingleton<ICampusDimService, CampusDimService>();
            containerRegistry.RegisterSingleton<IClassificationDimService, ClassificationDimService>();
            containerRegistry.RegisterSingleton<ICourseDimService, CourseDimService>();
            containerRegistry.RegisterSingleton<ILibraryDimService, LibraryDimService>();
            containerRegistry.RegisterSingleton<IModuleDimService, ModuleDimService>();
            containerRegistry.RegisterSingleton<IRoomDimService, RoomDimService>();
            containerRegistry.RegisterSingleton<IUserDimService, UserDimService>();
            containerRegistry.RegisterSingleton<IYearDimService, YearDimService>();

            #endregion

            #region Facts

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

            #endregion

            #endregion
        }
    }
}