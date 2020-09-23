namespace ModernUICharts
{

    using Windows.Foundation;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    public class RowSeriesPanel : Grid
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            foreach (UIElement child in Children)
                child.Measure(availableSize);

            return base.MeasureOverride(availableSize);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            Size cellSize = new Size(finalSize.Width, finalSize.Height / Children.Count);
            int row = 0, col = 0;

            double leftposition = 0;
            foreach (UIElement child in Children)
            {
                double height= finalSize.Height;
                double width = child.DesiredSize.Width;
                double x = leftposition;
                double y = 0;
                Rect rect = new Rect(x, y, width, height);
                child.Arrange(rect);

                leftposition += width;
                col++;
            }
            return finalSize;
        }
    }
}
