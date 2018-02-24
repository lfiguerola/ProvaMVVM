using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace PruebaMVVM.Resources.Converters
{
    class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string stringValue = (string)value;
            if (string.IsNullOrEmpty(stringValue)) return Color.Purple;
            bool containsVowels = ContainsVowels(stringValue);
            if (containsVowels)
            {
                return Color.Blue;
            }
            else return Color.Red;
        }        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private static bool ContainsVowels(string stringValue)
        {
            return stringValue
                        .Any(n => char.ToUpper(n) == 'A' || char.ToUpper(n) == 'E' || char.ToUpper(n) == 'I' || char.ToUpper(n) == 'O' || char.ToUpper(n) == 'U');
        }
    }
}
