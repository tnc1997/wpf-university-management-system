using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class LibraryFactCampusDimSpecificationTests
    {
        public LibraryFactCampusDimSpecificationTests()
        {
            LibraryFacts = new[]
            {
                new LibraryFact {CampusDimId = 1},
                new LibraryFact {CampusDimId = 2},
                new LibraryFact {CampusDimId = 3}
            };
        }

        private LibraryFact[] LibraryFacts { get; }

        [Fact]
        public void LibraryFactCampusDimSpecification_CampusDimId_ArrayFiltered()
        {
            var libraryFactCampusDimSpecification = new LibraryFactCampusDimSpecification(1);

            Collection(
                LibraryFacts.Where(libraryFactCampusDimSpecification.IsSatisfiedBy),
                fact => Equal(LibraryFacts[0], fact)
            );
        }
    }
}