using System.Collections.Generic;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class LibraryBooksSeed
    {
        public static List<LibraryBook> ToList()
        {
            return new List<LibraryBook>
            {
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstAgile},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstAndroid},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstC},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstCSharp},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstDesignPatterns},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstHtml},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstJava},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstJavaScript},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstLearnToCode},
                new LibraryBook
                    {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstObjectOrientedProgramming},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstPmp},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstPython},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstRuby},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstSql},
                new LibraryBook {Library = LibrariesSeed.ParkLibrary, Book = BooksSeed.HeadFirstStatistics}
            };
        }
    }
}