using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Result.ViewModels
{
    /// <summary>
    ///     Declares members belonging to the results view model.
    /// </summary>
    public class ResultsViewModel : FactChartViewModelBase<ResultFact>
    {
        private ClassificationDim _classificationDim;
        private INotifyTaskCompletion<IEnumerable<ClassificationDim>> _classificationDimsTask;
        private ModuleDim _moduleDim;
        private INotifyTaskCompletion<IEnumerable<ModuleDim>> _moduleDimsTask;

        public ResultsViewModel(
            IClassificationDimService classificationDimService,
            IModuleDimService moduleDimService,
            IResultFactService resultFactService
        ) : base(resultFactService)
        {
            ClassificationDimService = classificationDimService;
            ModuleDimService = moduleDimService;
        }

        /// <summary>
        ///     Gets or sets the classification dimension filter.
        /// </summary>
        /// <remarks>
        ///     When the user selects a new dimension from the list of filters, the dictionary of specifications,
        ///     which is used to filter the facts returned from the database, is updated with the value of the
        ///     selected dimension. If the selected dimension has been cleared by the user, then its value in the
        ///     dictionary is nullified in order to preclude it from future queries in the database.
        /// </remarks>
        public ClassificationDim ClassificationDim
        {
            get => _classificationDim;
            set
            {
                if (!SetProperty(ref _classificationDim, value)) return;

                Specifications[typeof(ClassificationDim)] = _classificationDim == null
                    ? null
                    : new ResultFactClassificationDimSpecification(_classificationDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<ClassificationDim>> ClassificationDimsTask
        {
            get => _classificationDimsTask;
            private set => SetProperty(ref _classificationDimsTask, value);
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
                    : new ResultFactModuleDimSpecification(_moduleDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<ModuleDim>> ModuleDimsTask
        {
            get => _moduleDimsTask;
            private set => SetProperty(ref _moduleDimsTask, value);
        }

        private IClassificationDimService ClassificationDimService { get; }

        private IModuleDimService ModuleDimService { get; }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            ClassificationDim = null;
            ModuleDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var task1 = Task.Run(ClassificationDimService.GetAsync);
            ClassificationDimsTask = new NotifyTaskCompletion<IEnumerable<ClassificationDim>>(task1);

            var task2 = Task.Run(ModuleDimService.GetAsync);
            ModuleDimsTask = new NotifyTaskCompletion<IEnumerable<ModuleDim>>(task2);
        }
    }
}