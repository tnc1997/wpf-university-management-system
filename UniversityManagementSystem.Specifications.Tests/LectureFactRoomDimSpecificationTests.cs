using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class LectureFactRoomDimSpecificationTests
    {
        public LectureFactRoomDimSpecificationTests()
        {
            LectureFacts = new[]
            {
                new LectureFact {RoomDimId = 1},
                new LectureFact {RoomDimId = 2},
                new LectureFact {RoomDimId = 3}
            };
        }

        private LectureFact[] LectureFacts { get; }

        [Fact]
        public void LectureFactRoomDimSpecification_RoomDimId_ArrayFiltered()
        {
            var lectureFactRoomDimSpecification = new LectureFactRoomDimSpecification(1);

            Collection(
                LectureFacts.Where(lectureFactRoomDimSpecification.IsSatisfiedBy),
                fact => Equal(LectureFacts[0], fact)
            );
        }
    }
}