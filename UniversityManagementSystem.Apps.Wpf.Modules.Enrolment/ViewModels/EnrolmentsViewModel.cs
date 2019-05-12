using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Enrolment.ViewModels
{
    /// <summary>
    ///     Declares members belonging to the enrolments view model.
    /// </summary>
    public class EnrolmentsViewModel : FactChartViewModelBase<EnrolmentFact>
    {
        private ModuleDim _moduleDim;
        private INotifyTaskCompletion<IEnumerable<ModuleDim>> _moduleDimsTask;

        public EnrolmentsViewModel(
            IEnrolmentFactService enrolmentFactService,
            IModuleDimService moduleDimService
        ) : base(enrolmentFactService)
        {
            ModuleDimService = moduleDimService;
        }

        /// <summary>
        ///     Gets or sets the module dimension filter.
        /// </summary>
        /// <remarks>
        ///     When the user selects a new dimension from the list of filters, the dictionary of specifications,
        ///     which is used to filter the facts returned from the database, is updated with the value of the
        ///     selected dimension. If the selected dimension has been cleared by the user, then its value in the
        ///     dictionary is nullified in order to preclude it from future queries in the database.
        /// </remarks>
        public ModuleDim ModuleDim
        {
            get => _moduleDim;
            set
            {
                if (!SetProperty(ref _moduleDim, value)) return;

                Specifications[typeof(ModuleDim)] = _moduleDim == null
                    ? null
                    : new EnrolmentFactModuleDimSpecification(_moduleDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<ModuleDim>> ModuleDimsTask
        {
            get => _moduleDimsTask;
            private set => SetProperty(ref _moduleDimsTask, value);
        }

        private IModuleDimService ModuleDimService { get; }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            ModuleDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var task = Task.Run(ModuleDimService.GetAsync);
            ModuleDimsTask = new NotifyTaskCompletion<IEnumerable<ModuleDim>>(task);
        }
    }
}