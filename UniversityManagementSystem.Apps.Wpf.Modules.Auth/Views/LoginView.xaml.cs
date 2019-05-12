using System.Windows;
using System.Windows.Controls;
using UniversityManagementSystem.Apps.Wpf.Modules.Auth.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Auth.Views
{
    public partial class LoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Occurs when the password of the password box control changes.
        /// </summary>
        /// <remarks>
        ///     https://stackoverflow.com/a/25001115
        /// </remarks>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext != null) ((LoginViewModel) DataContext).Password = ((PasswordBox) sender).SecurePassword;
        }
    }
}