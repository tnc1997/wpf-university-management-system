using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class RentalFactBookDimSpecificationTests
    {
        public RentalFactBookDimSpecificationTests()
        {
            RentalFacts = new[]
            {
                new RentalFact {BookDimId = 1},
                new RentalFact {BookDimId = 2},
                new RentalFact {BookDimId = 3}
            };
        }

        private RentalFact[] RentalFacts { get; }

        [Fact]
        public void RentalFactBookDimSpecification_BookDimId_ArrayFiltered()
        {
            var rentalFactBookDimSpecification = new RentalFactBookDimSpecification(1);

            Collection(
                RentalFacts.Where(rentalFactBookDimSpecification.IsSatisfiedBy),
                fact => Equal(RentalFacts[0], fact)
            );
        }
    }
}