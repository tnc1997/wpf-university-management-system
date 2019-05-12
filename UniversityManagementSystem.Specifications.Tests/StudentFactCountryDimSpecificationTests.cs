using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class StudentFactCountryDimSpecificationTests
    {
        public StudentFactCountryDimSpecificationTests()
        {
            StudentFacts = new[]
            {
                new StudentFact {CountryDimId = 1},
                new StudentFact {CountryDimId = 2},
                new StudentFact {CountryDimId = 3}
            };
        }

        private StudentFact[] StudentFacts { get; }

        [Fact]
        public void StudentFactCountryDimSpecification_CountryDimId_ArrayFiltered()
        {
            var studentFactCountryDimSpecification = new StudentFactCountryDimSpecification(1);

            Collection(
                StudentFacts.Where(studentFactCountryDimSpecification.IsSatisfiedBy),
                fact => Equal(StudentFacts[0], fact)
            );
        }
    }
}