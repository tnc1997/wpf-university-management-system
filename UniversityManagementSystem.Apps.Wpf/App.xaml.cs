using System.Windows;
using System.Windows.Threading;
using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Assignment;
using UniversityManagementSystem.Apps.Wpf.Modules.Auth;
using UniversityManagementSystem.Apps.Wpf.Modules.Book;
using UniversityManagementSystem.Apps.Wpf.Modules.Enrolment;
using UniversityManagementSystem.Apps.Wpf.Modules.Graduation;
using UniversityManagementSystem.Apps.Wpf.Modules.Home;
using UniversityManagementSystem.Apps.Wpf.Modules.Lecture;
using UniversityManagementSystem.Apps.Wpf.Modules.Library;
using UniversityManagementSystem.Apps.Wpf.Modules.Main;
using UniversityManagementSystem.Apps.Wpf.Modules.Module;
using UniversityManagementSystem.Apps.Wpf.Modules.Rental;
using UniversityManagementSystem.Apps.Wpf.Modules.Result;
using UniversityManagementSystem.Apps.Wpf.Modules.Room;
using UniversityManagementSystem.Apps.Wpf.Modules.Student;
using UniversityManagementSystem.Apps.Wpf.Views;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf
{
    /// <summary>
    ///     Defines the main methods used to setup and configure the app.
    /// </summary>
    public partial class App
    {
        /// <inheritdoc />
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<AssignmentModule>();
            moduleCatalog.AddModule<AuthModule>();
            moduleCatalog.AddModule<BookModule>();
            moduleCatalog.AddModule<EnrolmentModule>();
            moduleCatalog.AddModule<GraduationModule>();
            moduleCatalog.AddModule<HomeModule>();
            moduleCatalog.AddModule<LectureModule>();
            moduleCatalog.AddModule<LibraryModule>();
            moduleCatalog.AddModule<MainModule>();
            moduleCatalog.AddModule<ModuleModule>();
            moduleCatalog.AddModule<RentalModule>();
            moduleCatalog.AddModule<ResultModule>();
            moduleCatalog.AddModule<RoomModule>();
            moduleCatalog.AddModule<StudentModule>();
        }

        /// <inheritdoc />
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        /// <inheritdoc />
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            #region Services

            containerRegistry.RegisterSingleton<IUserService, UserService>();

            #region Dims

            containerRegistry.RegisterSingleton<IBookDimService, BookDimService>();
            containerRegistry.RegisterSingleton<ICampusDimService, CampusDimService>();
            containerRegistry.RegisterSingleton<IClassificationDimService, ClassificationDimService>();
            containerRegistry.RegisterSingleton<ICountryDimService, CountryDimService>();
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
            containerRegistry.RegisterSingleton<IEnrolmentFactService, EnrolmentFactService>();
            containerRegistry.RegisterSingleton<IGraduationFactService, GraduationFactService>();
            containerRegistry.RegisterSingleton<IHallFactService, HallFactService>();
            containerRegistry.RegisterSingleton<ILectureFactService, LectureFactService>();
            containerRegistry.RegisterSingleton<ILibraryFactService, LibraryFactService>();
            containerRegistry.RegisterSingleton<IModuleFactService, ModuleFactService>();
            containerRegistry.RegisterSingleton<IRentalFactService, RentalFactService>();
            containerRegistry.RegisterSingleton<IRoomFactService, RoomFactService>();
            containerRegistry.RegisterSingleton<IResultFactService, ResultFactService>();
            containerRegistry.RegisterSingleton<IStudentFactService, StudentFactService>();

            #endregion

            #endregion
        }

        /// <summary>
        ///     Occurs when an exception is thrown by the application but not handled.
        /// </summary>
        /// <param name="sender">The sender of the exception.</param>
        /// <param name="e">The exception event arguments.</param>
        private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            e.Handled = true;
        }
    }
}