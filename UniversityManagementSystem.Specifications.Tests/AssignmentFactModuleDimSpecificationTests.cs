using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class AssignmentFactModuleDimSpecificationTests
    {
        public AssignmentFactModuleDimSpecificationTests()
        {
            AssignmentFacts = new[]
            {
                new AssignmentFact {ModuleDimId = 1},
                new AssignmentFact {ModuleDimId = 2},
                new AssignmentFact {ModuleDimId = 3}
            };
        }

        private AssignmentFact[] AssignmentFacts { get; }

        [Fact]
        public void AssignmentFactModuleDimSpecification_ModuleDimId_ArrayFiltered()
        {
            var assignmentFactModuleDimSpecification = new AssignmentFactModuleDimSpecification(1);

            Collection(
                AssignmentFacts.Where(assignmentFactModuleDimSpecification.IsSatisfiedBy),
                fact => Equal(AssignmentFacts[0], fact)
            );
        }
    }
}