using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class GraduationFactCourseDimSpecificationTests
    {
        public GraduationFactCourseDimSpecificationTests()
        {
            GraduationFacts = new[]
            {
                new GraduationFact {CourseDimId = 1},
                new GraduationFact {CourseDimId = 2},
                new GraduationFact {CourseDimId = 3}
            };
        }

        private GraduationFact[] GraduationFacts { get; }

        [Fact]
        public void GraduationFactCourseDimSpecification_CourseDim_ArrayFiltered()
        {
            var graduationFactCourseDimSpecification = new GraduationFactCourseDimSpecification(1);

            Collection(
                GraduationFacts.Where(graduationFactCourseDimSpecification.IsSatisfiedBy),
                fact => Equal(GraduationFacts[0], fact)
            );
        }
    }
}