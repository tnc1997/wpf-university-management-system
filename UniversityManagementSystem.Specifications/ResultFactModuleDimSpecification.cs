using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class ResultFactModuleDimSpecification : SpecificationBase<ResultFact>
    {
        public ResultFactModuleDimSpecification(int moduleDimId)
        {
            Expression = fact => fact.ModuleDimId == moduleDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<ResultFact, bool>> Expression { get; }
    }
}