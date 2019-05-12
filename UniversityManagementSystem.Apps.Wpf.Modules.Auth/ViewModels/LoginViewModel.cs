using System.Security;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Auth.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private bool _isAwaiting;
        private SecureString _password;
        private string _username;

        public LoginViewModel(IRegionManager regionManager, IUserService userService)
        {
            RegionManager = regionManager;
            UserService = userService;

            LoginCommand = new DelegateCommand(OnLoginAsync, CanLogin)
                .ObservesProperty(() => Username)
                .ObservesProperty(() => IsAwaiting);
        }

        public DelegateCommand LoginCommand { get; }

        public bool IsAwaiting
        {
            get => _isAwaiting;
            private set => SetProperty(ref _isAwaiting, value);
        }

        private IRegionManager RegionManager { get; }

        private IUserService UserService { get; }

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public SecureString Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            Username = string.Empty;
            Password = new SecureString();
        }

        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(Username) && !IsAwaiting;
        }

        private async void OnLoginAsync()
        {
            IsAwaiting = true;
            var isLoginValid = await Task.Run(() => UserService.GetAsync(Username, Password)) != null;
            IsAwaiting = false;

            if (isLoginValid) RegionManager.RequestNavigate("ContentRegion", "MainView");
        }
    }
}