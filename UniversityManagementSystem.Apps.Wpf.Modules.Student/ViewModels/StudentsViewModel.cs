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
    /// <summary>
    ///     Declares members belonging to the students view model.
    /// </summary>
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

        /// <summary>
        ///     Gets or sets the country dimension filter.
        /// </summary>
        /// <remarks>
        ///     When the user selects a new dimension from the list of filters, the dictionary of specifications,
        ///     which is used to filter the facts returned from the database, is updated with the value of the
        ///     selected dimension. If the selected dimension has been cleared by the user, then its value in the
        ///     dictionary is nullified in order to preclude it from future queries in the database.
        /// </remarks>
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