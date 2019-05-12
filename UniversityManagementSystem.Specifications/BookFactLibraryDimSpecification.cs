using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class BookFactLibraryDimSpecification : SpecificationBase<BookFact>
    {
        public BookFactLibraryDimSpecification(int libraryDimId)
        {
            Expression = fact => fact.LibraryDimId == libraryDimId;
        }

        public override Expression<Func<BookFact, bool>> Expression { get; }
    }
}