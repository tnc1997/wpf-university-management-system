using System.Threading.Tasks;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;

namespace UniversityManagementSystem.Apps.Wpf.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        public MainWindowViewModel(IAssignmentFactService assignmentFactService, IUserService userService)
        {
            AssignmentFactService = assignmentFactService;
            UserService = userService;
        }

        private IAssignmentFactService AssignmentFactService { get; }

        private IUserService UserService { get; }

        public override async Task LoadAsync()
        {
            var specification = new AssignmentFactYearSpecification(4) & new AssignmentFactModuleSpecification(391);
            var noOfAssignments = await AssignmentFactService.GetSumAsync(specification);

            var user = await UserService.GetAsync("abby.harwick", "jUVX3i17x");
        }
    }
}