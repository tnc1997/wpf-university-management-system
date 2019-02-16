using Prism.Commands;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public interface ILoginPageViewModel : IViewModel
    {
        DelegateCommand LoginCommand { get; }

        string Username { get; set; }

        string Password { get; set; }
    }
}