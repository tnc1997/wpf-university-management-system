using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Module.ViewModels
{
    public class ModulesViewModel : FactChartViewModelBase<ModuleFact>
    {
        private CourseDim _courseDim;
        private INotifyTaskCompletion<IEnumerable<CourseDim>> _courseDimsTask;

        public ModulesViewModel(
            ICourseDimService courseDimService,
            IModuleFactService moduleFactService
        ) : base(moduleFactService)
        {
            CourseDimService = courseDimService;
        }

        public CourseDim CourseDim
        {
            get => _courseDim;
            set
            {
                if (!SetProperty(ref _courseDim, value)) return;

                Specifications[typeof(CourseDim)] = _courseDim == null
                    ? null
                    : new ModuleFactCourseDimSpecification(_courseDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<CourseDim>> CourseDimsTask
        {
            get => _courseDimsTask;
            private set => SetProperty(ref _courseDimsTask, value);
        }

        private ICourseDimService CourseDimService { get; }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            CourseDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var task = Task.Run(CourseDimService.GetAsync);
            CourseDimsTask = new NotifyTaskCompletion<IEnumerable<CourseDim>>(task);
        }
    }
}