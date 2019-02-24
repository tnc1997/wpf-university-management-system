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