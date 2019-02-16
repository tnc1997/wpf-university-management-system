using System.Threading.Tasks;
using Prism.Commands;
using Prism.Regions;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public class LoginPageViewModel : ViewModelBase, ILoginPageViewModel
    {
        private string _username;
        private string _password;

        public LoginPageViewModel(IRegionManager regionManager, IUserService userService)
        {
            RegionManager = regionManager;
            UserService = userService;

            LoginCommand = new DelegateCommand(OnLoginAsync, CanLogin)
                .ObservesProperty(() => Username)
                .ObservesProperty(() => Password);
        }

        private IRegionManager RegionManager { get; }

        private IUserService UserService { get; }

        public DelegateCommand LoginCommand { get; }

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        }

        private async Task LoginAsync()
        {
            if (await UserService.GetAsync(Username, Password) != null)
                RegionManager.RequestNavigate("ContentRegion", "MainPage");
        }

        private async void OnLoginAsync()
        {
            await LoginAsync();
        }
    }
}