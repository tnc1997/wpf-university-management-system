using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Regions;
using UniversityManagementSystem.Apps.Wpf.ViewModels;
using UniversityManagementSystem.Data.Entities;
using UniversityManagementSystem.Services;
using UniversityManagementSystem.Specifications;
using UniversityManagementSystem.ViewModels;

namespace UniversityManagementSystem.Apps.Wpf.Modules.Book.ViewModels
{
    public class BooksViewModel : FactChartViewModelBase<BookFact>
    {
        private LibraryDim _libraryDim;
        private INotifyTaskCompletion<IEnumerable<LibraryDim>> _libraryDimsTask;

        public BooksViewModel(
            IBookFactService bookFactService,
            ILibraryDimService libraryDimService
        ) : base(bookFactService)
        {
            LibraryDimService = libraryDimService;
        }

        public LibraryDim LibraryDim
        {
            get => _libraryDim;
            set
            {
                if (!SetProperty(ref _libraryDim, value)) return;

                Specifications[typeof(LibraryDim)] = _libraryDim == null
                    ? null
                    : new BookFactLibraryDimSpecification(_libraryDim.Id);

                UpdateSeriesCollection();
            }
        }

        public INotifyTaskCompletion<IEnumerable<LibraryDim>> LibraryDimsTask
        {
            get => _libraryDimsTask;
            private set => SetProperty(ref _libraryDimsTask, value);
        }

        private ILibraryDimService LibraryDimService { get; }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            LibraryDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            var task = Task.Run(LibraryDimService.GetAsync);
            LibraryDimsTask = new NotifyTaskCompletion<IEnumerable<LibraryDim>>(task);
        }
    }
}