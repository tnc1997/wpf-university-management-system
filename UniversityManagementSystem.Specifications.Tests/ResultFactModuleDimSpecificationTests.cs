using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class ResultFactModuleDimSpecificationTests
    {
        public ResultFactModuleDimSpecificationTests()
        {
            ResultFacts = new[]
            {
                new ResultFact {ModuleDimId = 1},
                new ResultFact {ModuleDimId = 2},
                new ResultFact {ModuleDimId = 3}
            };
        }

        private ResultFact[] ResultFacts { get; }

        [Fact]
        public void ResultFactModuleDimSpecification_ModuleDimId_ArrayFiltered()
        {
            var resultFactModuleDimSpecification = new ResultFactModuleDimSpecification(1);

            Collection(
                ResultFacts.Where(resultFactModuleDimSpecification.IsSatisfiedBy),
                fact => Equal(ResultFacts[0], fact)
            );
        }
    }
}