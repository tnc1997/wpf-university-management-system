using System;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Data.Initializers.Seeds
{
    internal static class RentalsSeed
    {
        #region AbbyHarwick

        public static Rental AbbyHarwickHeadFirstAgileRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2016, 12, 1),
            ReturnDate = new DateTime(2016, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstAgile
        };

        public static Rental AbbyHarwickHeadFirstAgileRental2 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2018, 12, 1),
            ReturnDate = new DateTime(2018, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstAgile
        };

        public static Rental AbbyHarwickHeadFirstAndroidRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2016, 12, 1),
            ReturnDate = new DateTime(2016, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstAndroid
        };

        public static Rental AbbyHarwickHeadFirstCRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2015, 12, 1),
            ReturnDate = new DateTime(2015, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstC
        };

        public static Rental AbbyHarwickHeadFirstCRental2 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2018, 12, 1),
            ReturnDate = new DateTime(2018, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstC
        };

        public static Rental AbbyHarwickHeadFirstCSharpRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2018, 12, 1),
            ReturnDate = new DateTime(2018, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstCSharp
        };

        public static Rental AbbyHarwickHeadFirstJavaRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2015, 12, 1),
            ReturnDate = new DateTime(2015, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstJava
        };

        public static Rental AbbyHarwickHeadFirstJavaScriptRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2015, 12, 1),
            ReturnDate = new DateTime(2015, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstJavaScript
        };

        public static Rental AbbyHarwickHeadFirstJavaScriptRental2 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2016, 12, 1),
            ReturnDate = new DateTime(2016, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstJavaScript
        };

        public static Rental AbbyHarwickHeadFirstHtmlRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2015, 12, 1),
            ReturnDate = new DateTime(2015, 12, 8),
            User = UsersSeed.AbbyHarwick,
            Book = BooksSeed.HeadFirstHtml
        };

        #endregion

        #region AbbyeHurdidge

        public static Rental AbbyeHurdidgeHeadFirstAgileRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2015, 12, 1),
            ReturnDate = new DateTime(2015, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstAgile
        };

        public static Rental AbbyeHurdidgeHeadFirstAgileRental2 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2016, 12, 1),
            ReturnDate = new DateTime(2016, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstAgile
        };

        public static Rental AbbyeHurdidgeHeadFirstAndroidRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2015, 12, 1),
            ReturnDate = new DateTime(2015, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstAndroid
        };

        public static Rental AbbyeHurdidgeHeadFirstCRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2015, 12, 1),
            ReturnDate = new DateTime(2015, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstC
        };

        public static Rental AbbyeHurdidgeHeadFirstCRental2 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2016, 12, 1),
            ReturnDate = new DateTime(2016, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstC
        };

        public static Rental AbbyeHurdidgeHeadFirstCSharpRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2018, 12, 1),
            ReturnDate = new DateTime(2018, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstCSharp
        };

        public static Rental AbbyeHurdidgeHeadFirstJavaRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2016, 12, 1),
            ReturnDate = new DateTime(2016, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstJava
        };

        public static Rental AbbyeHurdidgeHeadFirstJavaScriptRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2016, 12, 1),
            ReturnDate = new DateTime(2016, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstJavaScript
        };

        public static Rental AbbyeHurdidgeHeadFirstJavaScriptRental2 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2018, 12, 1),
            ReturnDate = new DateTime(2018, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstJavaScript
        };

        public static Rental AbbyeHurdidgeHeadFirstHtmlRental1 { get; } = new Rental
        {
            CheckoutDate = new DateTime(2016, 12, 1),
            ReturnDate = new DateTime(2016, 12, 8),
            User = UsersSeed.AbbyeHurdidge,
            Book = BooksSeed.HeadFirstHtml
        };

        #endregion
        
        public static Rental[] ToArray()
        {
            return new []
            {
                AbbyHarwickHeadFirstAgileRental1,
                AbbyHarwickHeadFirstAgileRental2,
                AbbyHarwickHeadFirstAndroidRental1,
                AbbyHarwickHeadFirstCRental1,
                AbbyHarwickHeadFirstCRental2,
                AbbyHarwickHeadFirstCSharpRental1,
                AbbyHarwickHeadFirstJavaRental1,
                AbbyHarwickHeadFirstJavaScriptRental1,
                AbbyHarwickHeadFirstJavaScriptRental2,
                AbbyHarwickHeadFirstHtmlRental1,
                AbbyeHurdidgeHeadFirstAgileRental1,
                AbbyeHurdidgeHeadFirstAgileRental2,
                AbbyeHurdidgeHeadFirstAndroidRental1,
                AbbyeHurdidgeHeadFirstCRental1,
                AbbyeHurdidgeHeadFirstCRental2,
                AbbyeHurdidgeHeadFirstCSharpRental1,
                AbbyeHurdidgeHeadFirstJavaRental1,
                AbbyeHurdidgeHeadFirstJavaScriptRental1,
                AbbyeHurdidgeHeadFirstJavaScriptRental2,
                AbbyeHurdidgeHeadFirstHtmlRental1
            };
        }
    }
}