using Prism.Ioc;
using Prism.Modularity;
using UniversityManagementSystem.Apps.Wpf.Modules.Book.ViewModels;
using UniversityManagementSystem.Apps.Wpf.Modules.Book.Views;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Book
{
    public class BookModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<BooksView, BooksViewModel>();
        }
    }
}