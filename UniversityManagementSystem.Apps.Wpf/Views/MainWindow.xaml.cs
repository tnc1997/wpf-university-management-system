using System;
using UniversityManagementSystem.Apps.Wpf.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Views
{
    public partial class MainWindow
    {
        public MainWindow(IMainWindowViewModel viewModel)
        {
            ViewModel = viewModel;

            InitializeComponent();
        }

        private IMainWindowViewModel ViewModel { get; }

        protected override async void OnInitialized(EventArgs e)
        {
            DataContext = ViewModel;

            await ViewModel.LoadAsync();

            base.OnInitialized(e);
        }
    }
}