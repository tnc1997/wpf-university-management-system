using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class ModuleFactCourseDimSpecification : SpecificationBase<ModuleFact>
    {
        public ModuleFactCourseDimSpecification(int courseDimId)
        {
            Expression = fact => fact.CourseDimId == courseDimId;
        }

        public override Expression<Func<ModuleFact, bool>> Expression { get; }
    }
}