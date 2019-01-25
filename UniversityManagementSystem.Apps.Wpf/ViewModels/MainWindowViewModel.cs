using System.Threading.Tasks;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        public MainWindowViewModel(IUserService userService)
        {
            UserService = userService;
        }

        private IUserService UserService { get; }

        public override async Task LoadAsync()
        {
            var users = await UserService.GetAsync();
        }
    }
}