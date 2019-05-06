using Prism.Mvvm;
using Prism.Regions;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    /// <summary>
    ///     Defines generic implementations for members which are shared between view models.
    /// </summary>
    public abstract class ViewModelBase : BindableBase, IViewModel
    {
        /// <inheritdoc />
        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <inheritdoc />
        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        /// <inheritdoc />
        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}