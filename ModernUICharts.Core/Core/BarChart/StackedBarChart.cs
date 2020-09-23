namespace ModernUICharts
{
    /// <summary>
    /// Represents an Instance of the bar-chart
    /// </summary>
    public class StackedBarChart : ChartBase
    {
        /// <summary>
        /// Initializes the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        static StackedBarChart()        
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        public StackedBarChart()
        {
            this.DefaultStyleKey = typeof(StackedBarChart);
        }

        protected override double GridLinesMaxValue
        {
            get
            {
                return MaxDataPointGroupSum;
            }
        }

        protected override void OnMaxDataPointGroupSumChanged(double p)
        {
            UpdateGridLines();
        }
    }
}