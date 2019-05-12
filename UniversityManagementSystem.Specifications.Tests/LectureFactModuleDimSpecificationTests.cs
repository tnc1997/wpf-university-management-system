using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class LectureFactModuleDimSpecificationTests
    {
        public LectureFactModuleDimSpecificationTests()
        {
            LectureFacts = new[]
            {
                new LectureFact {ModuleDimId = 1},
                new LectureFact {ModuleDimId = 2},
                new LectureFact {ModuleDimId = 3}
            };
        }

        private LectureFact[] LectureFacts { get; }

        [Fact]
        public void LectureFactModuleDimSpecification_ModuleDimId_ArrayFiltered()
        {
            var lectureFactModuleDimSpecification = new LectureFactModuleDimSpecification(1);

            Collection(
                LectureFacts.Where(lectureFactModuleDimSpecification.IsSatisfiedBy),
                fact => Equal(LectureFacts[0], fact)
            );
        }
    }
}