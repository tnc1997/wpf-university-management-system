using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class StudentFactCountryDimSpecification : SpecificationBase<StudentFact>
    {
        public StudentFactCountryDimSpecification(int countryDimId)
        {
            Expression = fact => fact.CountryDimId == countryDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<StudentFact, bool>> Expression { get; }
    }
}