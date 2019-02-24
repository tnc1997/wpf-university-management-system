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