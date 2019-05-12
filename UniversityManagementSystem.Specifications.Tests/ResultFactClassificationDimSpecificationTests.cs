using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class ResultFactClassificationDimSpecificationTests
    {
        public ResultFactClassificationDimSpecificationTests()
        {
            ResultFacts = new[]
            {
                new ResultFact {ClassificationDimId = 1},
                new ResultFact {ClassificationDimId = 2},
                new ResultFact {ClassificationDimId = 3}
            };
        }

        private ResultFact[] ResultFacts { get; }

        [Fact]
        public void ResultFactClassificationDimSpecification_ClassificationDimId_ArrayFiltered()
        {
            var resultFactClassificationDimSpecification = new ResultFactClassificationDimSpecification(1);

            Collection(
                ResultFacts.Where(resultFactClassificationDimSpecification.IsSatisfiedBy),
                fact => Equal(ResultFacts[0], fact)
            );
        }
    }
}