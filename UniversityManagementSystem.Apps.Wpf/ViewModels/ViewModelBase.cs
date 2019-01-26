using System.Threading.Tasks;
using Prism.Mvvm;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public abstract class ViewModelBase : BindableBase, IViewModel
    {
        public abstract Task LoadAsync();
    }
}