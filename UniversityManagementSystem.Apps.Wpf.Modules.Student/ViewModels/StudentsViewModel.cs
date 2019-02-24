using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Student.ViewModels
{
    public class StudentsViewModel : FactChartViewModelBase<StudentFact>
    {
        private CountryDim _countryDim;
        private INotifyTaskCompletion<IEnumerable<CountryDim>> _countryDimsTask;

        public StudentsViewModel(
            ICountryDimService countryDimService,
            IStudentFactService studentFactService
        ) : base(studentFactService)
        {
            CountryDimService = countryDimService;
        }

        public CountryDim CountryDim
        {
            get => _countryDim;
            set
            {
                if (!SetProperty(ref _countryDim, value)) return;

                Specifications[typeof(CountryDim)] = _countryDim == null
                    ? null
                    : new StudentFactCountryDimSpecification(_countryDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<CountryDim>> CountryDimsTask
        {
            get => _countryDimsTask;
            private set => SetProperty(ref _countryDimsTask, value);
        }

        private ICountryDimService CountryDimService { get; }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            CountryDimsTask = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var task = Task.Run(CountryDimService.GetAsync);
            CountryDimsTask = new NotifyTaskCompletion<IEnumerable<CountryDim>>(task);
        }
    }
}