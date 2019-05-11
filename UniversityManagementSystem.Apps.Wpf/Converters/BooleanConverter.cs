using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace UniversityManagementSystem.Apps.Wpf.Converters
{
    /// <summary>
    ///     https://stackoverflow.com/a/5182660
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public class BooleanConverter<TValue> : IValueConverter
    {
        public BooleanConverter(TValue trueValue, TValue falseValue)
        {
            True = trueValue;
            False = falseValue;
        }

        public TValue True { get; set; }

        public TValue False { get; set; }

        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool b && b ? True : False;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is TValue v && EqualityComparer<TValue>.Default.Equals(v, True);
        }
    }
}