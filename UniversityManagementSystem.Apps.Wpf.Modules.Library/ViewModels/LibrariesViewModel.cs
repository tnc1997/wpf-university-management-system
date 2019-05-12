using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Library.ViewModels
{
    /// <summary>
    ///     Declares members belonging to the libraries view model.
    /// </summary>
    public class LibrariesViewModel : FactChartViewModelBase<LibraryFact>
    {
        private CampusDim _campusDim;
        private INotifyTaskCompletion<IEnumerable<CampusDim>> _campusDimsTask;

        public LibrariesViewModel(
            ICampusDimService campusDimService,
            ILibraryFactService libraryFactService
        ) : base(libraryFactService)
        {
            CampusDimService = campusDimService;
        }

        /// <summary>
        ///     Gets or sets the campus dimension filter.
        /// </summary>
        /// <remarks>
        ///     When the user selects a new dimension from the list of filters, the dictionary of specifications,
        ///     which is used to filter the facts returned from the database, is updated with the value of the
        ///     selected dimension. If the selected dimension has been cleared by the user, then its value in the
        ///     dictionary is nullified in order to preclude it from future queries in the database.
        /// </remarks>
        public CampusDim CampusDim
        {
            get => _campusDim;
            set
            {
                if (!SetProperty(ref _campusDim, value)) return;

                Specifications[typeof(CampusDim)] = _campusDim == null
                    ? null
                    : new LibraryFactCampusDimSpecification(_campusDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<CampusDim>> CampusDimsTask
        {
            get => _campusDimsTask;
            private set => SetProperty(ref _campusDimsTask, value);
        }

        private ICampusDimService CampusDimService { get; }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            CampusDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var task = Task.Run(CampusDimService.GetAsync);
            CampusDimsTask = new NotifyTaskCompletion<IEnumerable<CampusDim>>(task);
        }
    }
}