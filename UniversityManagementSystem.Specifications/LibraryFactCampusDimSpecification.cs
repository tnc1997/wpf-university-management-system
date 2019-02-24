using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class LibraryFactCampusDimSpecification : SpecificationBase<LibraryFact>
    {
        public LibraryFactCampusDimSpecification(int campusDimId)
        {
            Expression = fact => fact.CampusDimId == campusDimId;
        }

        public override Expression<Func<LibraryFact, bool>> Expression { get; }
    }
}