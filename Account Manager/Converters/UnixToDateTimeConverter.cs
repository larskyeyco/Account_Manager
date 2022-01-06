using System;
using System.Globalization;
using System.Windows.Data;

namespace Account_Manager.Converters
{
    class UnixToDateTimeConverter : IValueConverter
    {
        readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is long v && targetType == typeof(string))
            {
                return epoch.AddMilliseconds(v);
            }
            else
            {
                return null;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
