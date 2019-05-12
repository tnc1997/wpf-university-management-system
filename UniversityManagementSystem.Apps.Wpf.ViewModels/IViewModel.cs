using System.ComponentModel;
using Prism.Regions;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    /// <summary>
    ///     Declares generic members that each view model must implement.
    /// </summary>
    public interface IViewModel : INavigationAware, INotifyPropertyChanged
    {
    }
}