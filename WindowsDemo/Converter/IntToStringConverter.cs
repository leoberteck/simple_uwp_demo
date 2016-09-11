using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace WindowsDemo.Converter
{
    public class IntToStringConverter : IValueConverter
    {
        //Converte de INT para STRING
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value?.ToString();
        }

        //Converte de STRING para INT
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            string str = value?.ToString();
            int result = 0;
            int.TryParse(str, out result);
            return result;
        }
    }
}
