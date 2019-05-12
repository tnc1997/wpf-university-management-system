using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications.Tests
{
    public abstract class CompositeSpecificationTestsBase
    {
        protected CompositeSpecificationTestsBase()
        {
            ResultFacts = new[]
            {
                new ResultFact {ModuleDimId = 1, ClassificationDimId = 1},
                new ResultFact {ModuleDimId = 1, ClassificationDimId = 2},
                new ResultFact {ModuleDimId = 2, ClassificationDimId = 1},
                new ResultFact {ModuleDimId = 2, ClassificationDimId = 2}
            };

            ResultFactModuleDimSpecification = new ResultFactModuleDimSpecification(1);

            ResultFactClassificationDimSpecification = new ResultFactClassificationDimSpecification(2);
        }

        protected ResultFact[] ResultFacts { get; }

        protected ResultFactModuleDimSpecification ResultFactModuleDimSpecification { get; }

        protected ResultFactClassificationDimSpecification ResultFactClassificationDimSpecification { get; }
    }
}