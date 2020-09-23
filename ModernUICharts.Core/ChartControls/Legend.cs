using System;
using System.Collections;
namespace ModernUICharts
{

    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Shapes;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml;
    using Windows.Foundation;
    using Windows.UI;
    using Windows.UI.Xaml.Media.Animation;
    using Windows.UI.Core;
    using Windows.UI.Xaml.Data;


    public class Legend : ItemsControl
    {
        static Legend()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PieChart"/> class.
        /// </summary>
        public Legend()
        {
        }

        public static readonly DependencyProperty ChartLegendItemStyleProperty =
            DependencyProperty.Register("ChartLegendItemStyle",
            typeof(Style),
            typeof(Legend),
            new PropertyMetadata(null, OnStyleChanged));

        private static void OnStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        public Style ChartLegendItemStyle
        {
            get { return (Style)GetValue(ChartLegendItemStyleProperty); }
            set { SetValue(ChartLegendItemStyleProperty, value); }
        }
    }
}
