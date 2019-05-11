using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Lecture.ViewModels
{
    /// <summary>
    ///     Declares members belonging to the lectures view model.
    /// </summary>
    public class LecturesViewModel : FactChartViewModelBase<LectureFact>
    {
        private ModuleDim _moduleDim;
        private INotifyTaskCompletion<IEnumerable<ModuleDim>> _moduleDimsTask;
        private RoomDim _roomDim;
        private INotifyTaskCompletion<IEnumerable<RoomDim>> _roomDimsTask;

        public LecturesViewModel(
            ILectureFactService lectureFactService,
            IModuleDimService moduleDimService,
            IRoomDimService roomDimService
        ) : base(lectureFactService)
        {
            ModuleDimService = moduleDimService;
            RoomDimService = roomDimService;
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
                    : new LectureFactModuleDimSpecification(_moduleDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<ModuleDim>> ModuleDimsTask
        {
            get => _moduleDimsTask;
            private set => SetProperty(ref _moduleDimsTask, value);
        }

        /// <summary>
        ///     Gets or sets the room dimension filter.
        /// </summary>
        /// <remarks>
        ///     When the user selects a new dimension from the list of filters, the dictionary of specifications,
        ///     which is used to filter the facts returned from the database, is updated with the value of the
        ///     selected dimension. If the selected dimension has been cleared by the user, then its value in the
        ///     dictionary is nullified in order to preclude it from future queries in the database.
        /// </remarks>
        public RoomDim RoomDim
        {
            get => _roomDim;
            set
            {
                if (!SetProperty(ref _roomDim, value)) return;

                Specifications[typeof(RoomDim)] = _roomDim == null
                    ? null
                    : new LectureFactRoomDimSpecification(_roomDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<RoomDim>> RoomDimsTask
        {
            get => _roomDimsTask;
            private set => SetProperty(ref _roomDimsTask, value);
        }

        private IModuleDimService ModuleDimService { get; }

        private IRoomDimService RoomDimService { get; }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            ModuleDim = null;
            RoomDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var task1 = Task.Run(ModuleDimService.GetAsync);
            ModuleDimsTask = new NotifyTaskCompletion<IEnumerable<ModuleDim>>(task1);

            var task2 = Task.Run(RoomDimService.GetAsync);
            RoomDimsTask = new NotifyTaskCompletion<IEnumerable<RoomDim>>(task2);
        }
    }
}