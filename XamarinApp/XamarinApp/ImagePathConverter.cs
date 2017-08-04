using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
    public class ImagePathConverter : IValueConverter
    {
        private static string _assembly;

        static ImagePathConverter()
        {
           _assembly = typeof(ImagePathConverter).AssemblyQualifiedName.Split(',')[1].Trim() + '.';
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string source = _assembly + ((string)value).Replace('/', '.');
            return ImageSource.FromResource(source);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
