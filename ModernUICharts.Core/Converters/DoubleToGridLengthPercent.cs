namespace ModernUICharts
{
    using System;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Data;

    public class DoubleToGridLengthPercent : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return InternalConvert(value, targetType, parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        private object InternalConvert(object value, Type targetType, object parameter)
        {
            double percentage = (double)value;
            if (parameter != null)
            {
                if (percentage <= 1)
                {
                    return new GridLength(1.0 - (double)percentage, GridUnitType.Star);
                }
                return new GridLength(100.0 - (double)percentage, GridUnitType.Star);
            }
            else
            {
                return new GridLength((double)percentage, GridUnitType.Star);
            }
        }
    }
}
