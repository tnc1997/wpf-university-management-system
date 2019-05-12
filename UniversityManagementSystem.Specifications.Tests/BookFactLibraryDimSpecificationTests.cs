using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class BookFactLibraryDimSpecificationTests
    {
        public BookFactLibraryDimSpecificationTests()
        {
            BookFacts = new[]
            {
                new BookFact {LibraryDimId = 1},
                new BookFact {LibraryDimId = 2},
                new BookFact {LibraryDimId = 3}
            };
        }

        private BookFact[] BookFacts { get; }

        [Fact]
        public void BookFactLibraryDimSpecification_LibraryDim_ArrayFiltered()
        {
            var bookFactLibraryDimSpecification = new BookFactLibraryDimSpecification(1);

            Collection(
                BookFacts.Where(bookFactLibraryDimSpecification.IsSatisfiedBy),
                fact => Equal(BookFacts[0], fact)
            );
        }
    }
}