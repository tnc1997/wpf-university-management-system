using System;

namespace UniversityManagementSystem.Data.Entities
{
    public interface IEntity : IEquatable<IEntity>
    {
        int Id { get; set; }
    }
}