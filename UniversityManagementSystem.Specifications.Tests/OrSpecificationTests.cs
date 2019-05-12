using System;
using System.Linq;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class OrSpecificationTests : CompositeSpecificationTestsBase
    {
        [Fact]
        public void OrSpecification_NullSpecificationsOrMethod_ArgumentNullExceptionThrown()
        {
            Throws<ArgumentNullException>(() => ResultFactModuleDimSpecification.Or(null));
        }

        [Fact]
        public void OrSpecification_NullSpecificationsOrOperator_ArgumentNullExceptionThrown()
        {
            Throws<ArgumentNullException>(() => ResultFactModuleDimSpecification | null);
        }

        [Fact]
        public void OrSpecification_SpecificationsOrMethod_SpecificationsOred()
        {
            var oredSpecification = ResultFactModuleDimSpecification.Or(ResultFactClassificationDimSpecification);

            Collection(
                ResultFacts.Where(oredSpecification.IsSatisfiedBy),
                fact => Equal(ResultFacts[0], fact),
                fact => Equal(ResultFacts[1], fact),
                fact => Equal(ResultFacts[3], fact)
            );
        }

        [Fact]
        public void OrSpecification_SpecificationsOrOperator_SpecificationsOred()
        {
            var oredSpecification = ResultFactModuleDimSpecification | ResultFactClassificationDimSpecification;

            Collection(
                ResultFacts.Where(oredSpecification.IsSatisfiedBy),
                fact => Equal(ResultFacts[0], fact),
                fact => Equal(ResultFacts[1], fact),
                fact => Equal(ResultFacts[3], fact)
            );
        }
    }
}