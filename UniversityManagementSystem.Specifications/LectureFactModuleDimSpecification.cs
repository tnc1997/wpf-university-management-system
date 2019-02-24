using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class LectureFactModuleDimSpecification : SpecificationBase<LectureFact>
    {
        public LectureFactModuleDimSpecification(int moduleDimId)
        {
            Expression = fact => fact.ModuleDimId == moduleDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<LectureFact, bool>> Expression { get; }
    }
}