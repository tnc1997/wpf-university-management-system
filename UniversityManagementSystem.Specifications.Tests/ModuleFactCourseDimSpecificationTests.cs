using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class ModuleFactCourseDimSpecificationTests
    {
        public ModuleFactCourseDimSpecificationTests()
        {
            ModuleFacts = new[]
            {
                new ModuleFact {CourseDimId = 1},
                new ModuleFact {CourseDimId = 2},
                new ModuleFact {CourseDimId = 3}
            };
        }

        private ModuleFact[] ModuleFacts { get; }

        [Fact]
        public void ModuleFactCourseDimSpecification_CourseDimId_ArrayFiltered()
        {
            var moduleFactCourseDimSpecification = new ModuleFactCourseDimSpecification(1);

            Collection(
                ModuleFacts.Where(moduleFactCourseDimSpecification.IsSatisfiedBy),
                fact => Equal(ModuleFacts[0], fact)
            );
        }
    }
}