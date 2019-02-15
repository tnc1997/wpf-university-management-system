using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class AssignmentFactYearSpecification : SpecificationBase<AssignmentFact>
    {
        public AssignmentFactYearSpecification(int yearDimId)
        {
            Expression = fact => fact.YearDimId == yearDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<AssignmentFact, bool>> Expression { get; }
    }
}