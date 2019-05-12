using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class EnrolmentFactModuleDimSpecificationTests
    {
        public EnrolmentFactModuleDimSpecificationTests()
        {
            EnrolmentFacts = new[]
            {
                new EnrolmentFact {ModuleDimId = 1},
                new EnrolmentFact {ModuleDimId = 2},
                new EnrolmentFact {ModuleDimId = 3}
            };
        }

        private EnrolmentFact[] EnrolmentFacts { get; }

        [Fact]
        public void EnrolmentFactModuleDimSpecification_ModuleDim_ArrayFiltered()
        {
            var enrolmentFactModuleDimSpecification = new EnrolmentFactModuleDimSpecification(1);

            Collection(
                EnrolmentFacts.Where(enrolmentFactModuleDimSpecification.IsSatisfiedBy),
                fact => Equal(EnrolmentFacts[0], fact)
            );
        }
    }
}