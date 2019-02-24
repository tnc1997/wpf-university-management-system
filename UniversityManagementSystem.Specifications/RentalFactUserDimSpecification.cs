using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class RentalFactUserDimSpecification : SpecificationBase<RentalFact>
    {
        public RentalFactUserDimSpecification(int userDimId)
        {
            Expression = fact => fact.UserDimId == userDimId;
        }

        public override Expression<Func<RentalFact, bool>> Expression { get; }
    }
}