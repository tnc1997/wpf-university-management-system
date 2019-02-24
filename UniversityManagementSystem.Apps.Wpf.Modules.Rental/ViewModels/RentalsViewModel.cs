using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Rental.ViewModels
{
    public class RentalsViewModel : FactChartViewModelBase<RentalFact>
    {
        private BookDim _bookDim;
        private INotifyTaskCompletion<IEnumerable<BookDim>> _bookDimsTask;
        private UserDim _userDim;
        private INotifyTaskCompletion<IEnumerable<UserDim>> _userDimsTask;

        public RentalsViewModel(
            IBookDimService bookDimService,
            IRentalFactService rentalFactService,
            IUserDimService userDimService
        ) : base(rentalFactService)
        {
            BookDimService = bookDimService;
            UserDimService = userDimService;
        }

        public BookDim BookDim
        {
            get => _bookDim;
            set
            {
                if (!SetProperty(ref _bookDim, value)) return;

                Specifications[typeof(BookDim)] = _bookDim == null
                    ? null
                    : new RentalFactBookDimSpecification(_bookDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<BookDim>> BookDimsTask
        {
            get => _bookDimsTask;
            private set => SetProperty(ref _bookDimsTask, value);
        }

        public UserDim UserDim
        {
            get => _userDim;
            set
            {
                if (!SetProperty(ref _userDim, value)) return;

                Specifications[typeof(UserDim)] = _userDim == null
                    ? null
                    : new RentalFactUserDimSpecification(_userDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<UserDim>> UserDimsTask
        {
            get => _userDimsTask;
            private set => SetProperty(ref _userDimsTask, value);
        }

        private IBookDimService BookDimService { get; }

        private IUserDimService UserDimService { get; }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            BookDim = null;
            UserDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var task1 = Task.Run(BookDimService.GetAsync);
            BookDimsTask = new NotifyTaskCompletion<IEnumerable<BookDim>>(task1);

            var task2 = Task.Run(UserDimService.GetAsync);
            UserDimsTask = new NotifyTaskCompletion<IEnumerable<UserDim>>(task2);
        }
    }
}