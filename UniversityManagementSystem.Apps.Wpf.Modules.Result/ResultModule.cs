using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Result.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Result.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Result
{
    public class ResultModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ResultsView, ResultsViewModel>();
        }
    }
}