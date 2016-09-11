using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace WindowsDemo.Converter
{
    public class NegateBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var boolval = (bool)value;
            return !boolval;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var boolval = (bool)value;
            return !boolval;
        }
    }
}
