using System.Collections.Generic;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class HallsSeed
    {
        public static Hall BlackfriarsResidences { get; } = new Hall
        {
            Name = "Blackfriars Residences",
            Campus = CampusesSeed.Oxstalls
        };

        public static Hall EildonAndMerrowdown { get; } = new Hall
        {
            Name = "Eildon & Merrowdown",
            Campus = CampusesSeed.Park
        };

        public static Hall EildonAndMerrowdownAnnexe { get; } = new Hall
        {
            Name = "Eildon & Merrowdown Annexe",
            Campus = CampusesSeed.Park
        };

        public static Hall ErminHall { get; } = new Hall
        {
            Name = "Ermin Hall",
            Campus = CampusesSeed.Oxstalls
        };

        public static Hall HardwickResidences { get; } = new Hall
        {
            Name = "Hardwick Residences",
            Campus = CampusesSeed.Hardwick
        };

        public static Hall OxstallsResidences { get; } = new Hall
        {
            Name = "Oxstalls Residences",
            Campus = CampusesSeed.Oxstalls
        };

        public static Hall ParkChallinor { get; } = new Hall
        {
            Name = "Park Challinor",
            Campus = CampusesSeed.Park
        };

        public static Hall ParkVillas { get; } = new Hall
        {
            Name = "Park Villas",
            Campus = CampusesSeed.Park
        };

        public static Hall ShaftesburyHall { get; } = new Hall
        {
            Name = "Shaftesbury Hall",
            Campus = CampusesSeed.FrancisCloseHall
        };

        public static Hall UpperQuay { get; } = new Hall
        {
            Name = "Upper Quay",
            Campus = CampusesSeed.Oxstalls
        };

        public static List<Hall> ToList()
        {
            return new List<Hall>
            {
                BlackfriarsResidences,
                EildonAndMerrowdown,
                EildonAndMerrowdownAnnexe,
                ErminHall,
                HardwickResidences,
                OxstallsResidences,
                ParkChallinor,
                ParkVillas,
                ShaftesburyHall,
                UpperQuay
            };
        }
    }
}