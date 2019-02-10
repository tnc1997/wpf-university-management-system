using System.Collections.Generic;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class BooksSeed
    {
        public static Book HeadFirstAgile { get; } = new Book
        {
            Name = "Head First Agile",
            Author = "Andrew Stellman"
        };

        public static Book HeadFirstAndroid { get; } = new Book
        {
            Name = "Head First Android",
            Author = "Dawn Griffiths"
        };

        public static Book HeadFirstC { get; } = new Book
        {
            Name = "Head First C",
            Author = "David Griffiths"
        };

        public static Book HeadFirstCSharp { get; } = new Book
        {
            Name = "Head First C#",
            Author = "Andrew Stellman"
        };

        public static Book HeadFirstDesignPatterns { get; } = new Book
        {
            Name = "Head First Design Patterns",
            Author = "Eric Freeman"
        };

        public static Book HeadFirstHtml { get; } = new Book
        {
            Name = "Head First HTML",
            Author = "Elisabeth Robson"
        };

        public static Book HeadFirstJava { get; } = new Book
        {
            Name = "Head First Java",
            Author = "Kathy Sierra"
        };

        public static Book HeadFirstJavaScript { get; } = new Book
        {
            Name = "Head First JavaScript",
            Author = "Eric Freeman"
        };

        public static Book HeadFirstLearnToCode { get; } = new Book
        {
            Name = "Head First Learn To Code",
            Author = "Eric Freeman"
        };

        public static Book HeadFirstObjectOrientedProgramming { get; } = new Book
        {
            Name = "Head First Object Oriented Programming",
            Author = "Brett McLaughlin"
        };

        public static Book HeadFirstPmp { get; } = new Book
        {
            Name = "Head First PMP",
            Author = "Jennifer Greene"
        };

        public static Book HeadFirstPython { get; } = new Book
        {
            Name = "Head First Python",
            Author = "Paul Barry"
        };

        public static Book HeadFirstRuby { get; } = new Book
        {
            Name = "Head First Ruby",
            Author = "Jay McGavren"
        };

        public static Book HeadFirstSql { get; } = new Book
        {
            Name = "Head First SQL",
            Author = "Lynn Beighley"
        };

        public static Book HeadFirstStatistics { get; } = new Book
        {
            Name = "Head First Statistics",
            Author = "Dawn Griffiths"
        };

        public static List<Book> ToList()
        {
            return new List<Book>
            {
                HeadFirstAgile,
                HeadFirstAndroid,
                HeadFirstC,
                HeadFirstCSharp,
                HeadFirstDesignPatterns,
                HeadFirstHtml,
                HeadFirstJava,
                HeadFirstJavaScript,
                HeadFirstLearnToCode,
                HeadFirstObjectOrientedProgramming,
                HeadFirstPmp,
                HeadFirstPython,
                HeadFirstRuby,
                HeadFirstSql,
                HeadFirstStatistics
            };
        }
    }
}