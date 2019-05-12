using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class ResultFactClassificationDimSpecification : SpecificationBase<ResultFact>
    {
        public ResultFactClassificationDimSpecification(int classificationDimId)
        {
            Expression = fact => fact.ClassificationDimId == classificationDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<ResultFact, bool>> Expression { get; }
    }
}