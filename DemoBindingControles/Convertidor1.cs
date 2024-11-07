using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DemoBindingControles
{
    class Convertidor1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cadena = value as string;
            switch (cadena.ToString().ToLower()) {
                case "yes":
                case "si":
                case "oui":
                    return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            MessageBox.Show("No pulses el checkbox con el ratón");
            return "Error...";

        }
    }
}
