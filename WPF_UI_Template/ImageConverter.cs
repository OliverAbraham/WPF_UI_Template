using System;
using System.Globalization;
using System.Windows.Data;

namespace WPF_UI_Template
{
	[ValueConversion(typeof(System.Drawing.Image), typeof(System.Windows.Media.ImageSource))]
    public sealed class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            var bitmapPath = (string)value;
            var bitmap = new System.Windows.Media.Imaging.BitmapImage(new Uri(bitmapPath, UriKind.Relative));
            return bitmap;
        }
 
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
