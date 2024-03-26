using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsn_maui_les_1.Converters
{
    public class DateTimeToDateOnlyConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is DateOnly)
            {
                DateOnly date = (DateOnly)value;
                return date.ToDateTime(TimeOnly.MinValue);
            }
            return DateTime.MinValue;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                DateTime date = (DateTime)value;
                return DateOnly.FromDateTime(date);
            }
            return DateOnly.MinValue;
        }
    }
}
