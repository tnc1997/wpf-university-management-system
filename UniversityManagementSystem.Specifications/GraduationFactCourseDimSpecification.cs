using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class GraduationFactCourseDimSpecification : SpecificationBase<GraduationFact>
    {
        public GraduationFactCourseDimSpecification(int courseDimId)
        {
            Expression = fact => fact.CourseDimId == courseDimId;
        }

        public override Expression<Func<GraduationFact, bool>> Expression { get; }
    }
}