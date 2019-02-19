using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Lecture.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Lecture.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Lecture
{
    public class LectureModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LecturesView, LecturesViewModel>();
        }
    }
}