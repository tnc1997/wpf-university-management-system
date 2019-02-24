using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class EnrolmentFactModuleDimSpecification : SpecificationBase<EnrolmentFact>
    {
        public EnrolmentFactModuleDimSpecification(int moduleDimId)
        {
            Expression = fact => fact.ModuleDimId == moduleDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<EnrolmentFact, bool>> Expression { get; }
    }
}