using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Graduation.ViewModels
{
    public class GraduationsViewModel : FactChartViewModelBase<GraduationFact>
    {
        private CourseDim _courseDim;
        private INotifyTaskCompletion<IEnumerable<CourseDim>> _courseDimsTask;

        public GraduationsViewModel(
            ICourseDimService courseDimService,
            IGraduationFactService graduationFactService
        ) : base(graduationFactService)
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
                    : new GraduationFactCourseDimSpecification(_courseDim.Id);

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