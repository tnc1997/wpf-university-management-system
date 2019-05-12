using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class RentalFactUserDimSpecificationTests
    {
        public RentalFactUserDimSpecificationTests()
        {
            RentalFacts = new[]
            {
                new RentalFact {UserDimId = 1},
                new RentalFact {UserDimId = 2},
                new RentalFact {UserDimId = 3}
            };
        }

        private RentalFact[] RentalFacts { get; }

        [Fact]
        public void RentalFactUserDimSpecification_UserDimId_ArrayFiltered()
        {
            var rentalFactUserDimSpecification = new RentalFactUserDimSpecification(1);

            Collection(
                RentalFacts.Where(rentalFactUserDimSpecification.IsSatisfiedBy),
                fact => Equal(RentalFacts[0], fact)
            );
        }
    }
}