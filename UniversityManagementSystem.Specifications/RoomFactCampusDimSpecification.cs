using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class RoomFactCampusDimSpecification : SpecificationBase<RoomFact>
    {
        public RoomFactCampusDimSpecification(int campusDimId)
        {
            Expression = fact => fact.CampusDimId == campusDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<RoomFact, bool>> Expression { get; }
    }
}