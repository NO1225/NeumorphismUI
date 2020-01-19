using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace NeumorphismUI
{
    /// <summary>
    /// A converter that takes in a boolean and returns a <see cref="Visibility"/>
    /// </summary>
    public class WidthHeightToRectangleConverter : BaseValueConverter<WidthHeightToRectangleConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var control = value as FrameworkElement;

            if (control == null)
                return null;

            return new System.Windows.Rect()
            {
                Height = control.Height,
                Width = control.Width,
                X = 6,
                Y = 6

            };

            if (parameter == null)
                return (bool)value ? Visibility.Hidden : Visibility.Visible;
            else
                return (bool)value ? Visibility.Visible : Visibility.Hidden;

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
