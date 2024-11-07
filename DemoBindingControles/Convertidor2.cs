using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DemoBindingControles
{
    class Convertidor2 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var activado = value as Boolean?;
            if (activado == true)
                return "Visible";
            else
                return "Hidden";

            /*
             return (bool)value?"Visible","Hidden";
             */

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
