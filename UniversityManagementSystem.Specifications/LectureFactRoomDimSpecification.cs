using System;
using System.Linq.Expressions;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Specifications
{
    public class LectureFactRoomDimSpecification : SpecificationBase<LectureFact>
    {
        public LectureFactRoomDimSpecification(int roomDimId)
        {
            Expression = fact => fact.RoomDimId == roomDimId;
        }

        /// <inheritdoc />
        public override Expression<Func<LectureFact, bool>> Expression { get; }
    }
}