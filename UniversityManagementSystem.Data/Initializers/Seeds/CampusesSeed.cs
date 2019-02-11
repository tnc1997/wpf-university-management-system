using System.Collections.Generic;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class CampusesSeed
    {
        public static Campus FrancisCloseHall { get; } = new Campus
        {
            Name = "Francis Close Hall"
        };

        public static Campus Hardwick { get; } = new Campus
        {
            Name = "Hardwick"
        };

        public static Campus Oxstalls { get; } = new Campus
        {
            Name = "Oxstalls"
        };

        public static Campus Park { get; } = new Campus
        {
            Name = "Park"
        };

        public static Campus[] ToArray()
        {
            return new []
            {
                FrancisCloseHall,
                Hardwick,
                Oxstalls,
                Park
            };
        }
    }
}