using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace Sulmar.WPFMVVM.Shop.WPFClient.Converters
{
    // [ValueConversion(typeof(Sex), typeof(Brush))]
    public class SexToBrushConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Sex sex)
            {
                if (sex == Sex.Female)
                    return Brushes.Pink;
                else
                    return Brushes.Green;
            }

            return new NotSupportedException();

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
