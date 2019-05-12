using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Student.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Student.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Student
{
    public class StudentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<StudentsView, StudentsViewModel>();
        }
    }
}