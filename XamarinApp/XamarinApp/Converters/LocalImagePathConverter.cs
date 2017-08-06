using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinApp.Converters
{
    public class LocalImagePathConverter : IValueConverter
    {
        private static string _assembly;

        static LocalImagePathConverter()
        {
           
            _assembly = typeof(LocalImagePathConverter).AssemblyQualifiedName.Split(',')[1].Trim() + '.';
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
