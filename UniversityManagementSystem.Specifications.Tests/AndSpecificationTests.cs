using System;
using System.Linq;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Specifications.Tests
{
    public class AndSpecificationTests : CompositeSpecificationTestsBase
    {
        [Fact]
        public void AndSpecification_NullSpecificationsAndMethod_ArgumentNullExceptionThrown()
        {
            Throws<ArgumentNullException>(() => ResultFactModuleDimSpecification.And(null));
        }

        [Fact]
        public void AndSpecification_NullSpecificationsAndOperator_ArgumentNullExceptionThrown()
        {
            Throws<ArgumentNullException>(() => ResultFactModuleDimSpecification & null);
        }

        [Fact]
        public void AndSpecification_SpecificationsAndMethod_SpecificationsAnded()
        {
            var andedSpecification = ResultFactModuleDimSpecification.And(ResultFactClassificationDimSpecification);

            Collection(
                ResultFacts.Where(andedSpecification.IsSatisfiedBy),
                fact => Equal(ResultFacts[1], fact)
            );
        }

        [Fact]
        public void AndSpecification_SpecificationsAndOperator_SpecificationsAnded()
        {
            var andedSpecification = ResultFactModuleDimSpecification & ResultFactClassificationDimSpecification;

            Collection(
                ResultFacts.Where(andedSpecification.IsSatisfiedBy),
                fact => Equal(ResultFacts[1], fact)
            );
        }
    }
}