using Prism.Mvvm;
using Prism.Regions;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public abstract class ViewModelBase : BindableBase, IViewModel
    {
        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}