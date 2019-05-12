using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class RolesSeed
    {
        public static Role Admin { get; } = new Role
        {
            Name = "Admin"
        };

        public static Role Staff { get; } = new Role
        {
            Name = "Staff"
        };

        public static Role Student { get; } = new Role
        {
            Name = "Student"
        };

        public static Role[] ToArray()
        {
            return new[]
            {
                Admin,
                Staff,
                Student
            };
        }
    }
}