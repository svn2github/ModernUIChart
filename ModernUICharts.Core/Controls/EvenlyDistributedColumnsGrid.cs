namespace ModernUICharts
{
    using System;
    using Windows.Foundation;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public class EvenlyDistributedColumnsGrid : Panel
    {
        public EvenlyDistributedColumnsGrid()
        {
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            try
            {
                double maxColumnWidth = 0.0;
                double minColumnHeight = 0.0;
                foreach (UIElement child in Children)
                {
                    if (Children.Count > 1)
                    {
                    }
                    child.Measure(availableSize);
                    if(maxColumnWidth < child.DesiredSize.Width)
                    {
                        maxColumnWidth = child.DesiredSize.Width;
                    }
                    if (minColumnHeight < child.DesiredSize.Height)
                    {
                        minColumnHeight = child.DesiredSize.Height;
                    }
                }
                availableSize.Width = maxColumnWidth * Children.Count;
                availableSize.Height = minColumnHeight;
                

               
                return availableSize;
            }
            catch (Exception ex)
            {
                return new Size(0,0);
            }            
        }

        private double GetHighestElement()
        {
            double highestElementHeight = 0.0;
            foreach (UIElement child in Children)
            {
                if (child.DesiredSize.Height > highestElementHeight)
                {
                    highestElementHeight = child.DesiredSize.Height;
                }
            }
            return highestElementHeight;
        }

        private Size GetCellSize(Size availableSize)
        {
            return new Size(availableSize.Width / Children.Count, availableSize.Height);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            //calculate the space for each column
            Size cellSize = GetCellSize(finalSize);
            double cellWidth = cellSize.Width;
            double cellHeight = cellSize.Height;

            int col = 0;
            foreach (UIElement child in Children)
            {
                double middlePointX = cellSize.Width * col + cellSize.Width / 2.0;
                child.Arrange(new Rect(new Point(middlePointX - cellWidth / 2.0, 0.0), new Size(cellWidth, cellHeight)));
                col++;
            }
            return finalSize;
        }
    }
}
