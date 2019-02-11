using System.Collections.Generic;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class LibrariesSeed
    {
        public static Library FrancisCloseHallNorthLibrary { get; } = new Library
        {
            Name = "Francis Close Hall North Library",
            Campus = CampusesSeed.FrancisCloseHall
        };

        public static Library FrancisCloseHallSouthLibrary { get; } = new Library
        {
            Name = "Francis Close Hall South Library",
            Campus = CampusesSeed.FrancisCloseHall
        };

        public static Library OxstallsLibrary { get; } = new Library
        {
            Name = "Oxstalls Library",
            Campus = CampusesSeed.Oxstalls
        };

        public static Library ParkLibrary { get; } = new Library
        {
            Name = "Park Library",
            Campus = CampusesSeed.Park
        };

        public static Library[] ToArray()
        {
            return new []
            {
                FrancisCloseHallNorthLibrary,
                FrancisCloseHallSouthLibrary,
                OxstallsLibrary,
                ParkLibrary
            };
        }
    }
}