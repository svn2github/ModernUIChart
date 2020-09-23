using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;


namespace ModernUICharts
{
    public class ChartTitle : ContentControl
    {        
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ChartTitle),
            new PropertyMetadata(null));
        public static readonly DependencyProperty SubTitleProperty =
            DependencyProperty.Register("SubTitle", typeof(string), typeof(ChartTitle),
            new PropertyMetadata(null));
     
        static ChartTitle()
        {
        }

        public ChartTitle()
        {
        }

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public string SubTitle
        {
            get
            {
                return (string)GetValue(SubTitleProperty);
            }
            set
            {
                SetValue(SubTitleProperty, value);
            }
        }
    }
}
