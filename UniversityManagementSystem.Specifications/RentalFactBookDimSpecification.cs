using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class RentalFactBookDimSpecification : SpecificationBase<RentalFact>
    {
        public RentalFactBookDimSpecification(int bookDimId)
        {
            Expression = fact => fact.BookDimId == bookDimId;
        }

        public override Expression<Func<RentalFact, bool>> Expression { get; }
    }
}