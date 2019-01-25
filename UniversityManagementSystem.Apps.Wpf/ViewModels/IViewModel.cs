using System.ComponentModel;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public interface IViewModel : INotifyPropertyChanged
    {
        Task LoadAsync();
    }
}