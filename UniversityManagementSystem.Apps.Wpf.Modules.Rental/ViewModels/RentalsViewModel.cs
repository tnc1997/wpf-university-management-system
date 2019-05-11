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
    /// <summary>
    ///     Declares members belonging to the rentals view model.
    /// </summary>
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

        /// <summary>
        ///     Gets or sets the book dimension filter.
        /// </summary>
        /// <remarks>
        ///     When the user selects a new dimension from the list of filters, the dictionary of specifications,
        ///     which is used to filter the facts returned from the database, is updated with the value of the
        ///     selected dimension. If the selected dimension has been cleared by the user, then its value in the
        ///     dictionary is nullified in order to preclude it from future queries in the database.
        /// </remarks>
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

        /// <summary>
        ///     Gets or sets the user dimension filter.
        /// </summary>
        /// <remarks>
        ///     When the user selects a new dimension from the list of filters, the dictionary of specifications,
        ///     which is used to filter the facts returned from the database, is updated with the value of the
        ///     selected dimension. If the selected dimension has been cleared by the user, then its value in the
        ///     dictionary is nullified in order to preclude it from future queries in the database.
        /// </remarks>
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