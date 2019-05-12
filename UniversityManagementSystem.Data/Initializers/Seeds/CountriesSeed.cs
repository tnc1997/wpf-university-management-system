using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class CountriesSeed
    {
        public static Country France { get; } = new Country
        {
            Name = "France"
        };

        public static Country Germany { get; } = new Country
        {
            Name = "Germany"
        };

        public static Country Greece { get; } = new Country
        {
            Name = "Greece"
        };

        public static Country Ireland { get; } = new Country
        {
            Name = "Ireland"
        };

        public static Country Italy { get; } = new Country
        {
            Name = "Italy"
        };

        public static Country Netherlands { get; } = new Country
        {
            Name = "Netherlands"
        };

        public static Country Poland { get; } = new Country
        {
            Name = "Poland"
        };

        public static Country Spain { get; } = new Country
        {
            Name = "Spain"
        };

        public static Country UnitedKingdom { get; } = new Country
        {
            Name = "United Kingdom"
        };

        public static Country UnitedStates { get; } = new Country
        {
            Name = "United States"
        };

        public static Country[] ToArray()
        {
            return new[]
            {
                France,
                Germany,
                Greece,
                Ireland,
                Italy,
                Netherlands,
                Poland,
                Spain,
                UnitedKingdom,
                UnitedStates
            };
        }
    }
}