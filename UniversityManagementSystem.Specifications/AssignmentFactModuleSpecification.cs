using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class AssignmentFactModuleSpecification : SpecificationBase<AssignmentFact>
    {
        public AssignmentFactModuleSpecification(int moduleDimId)
        {
            Expression = fact => fact.ModuleDimId == moduleDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<AssignmentFact, bool>> Expression { get; }
    }
}