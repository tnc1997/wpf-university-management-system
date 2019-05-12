using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class RoomFactCampusDimSpecificationTests
    {
        public RoomFactCampusDimSpecificationTests()
        {
            RoomFacts = new[]
            {
                new RoomFact {CampusDimId = 1},
                new RoomFact {CampusDimId = 2},
                new RoomFact {CampusDimId = 3}
            };
        }

        private RoomFact[] RoomFacts { get; }

        [Fact]
        public void RoomFactCampusDimSpecification_CampusDimId_ArrayFiltered()
        {
            var roomFactCampusDimSpecification = new RoomFactCampusDimSpecification(1);

            Collection(
                RoomFacts.Where(roomFactCampusDimSpecification.IsSatisfiedBy),
                fact => Equal(RoomFacts[0], fact)
            );
        }
    }
}