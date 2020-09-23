namespace ModernUICharts
{
    /// <summary>
    /// Represents an Instance of the bar-chart
    /// </summary>
    public class StackedColumnChart : ChartBase
    {
        /// <summary>
        /// Initializes the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        static StackedColumnChart()        
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        public StackedColumnChart()
        {
            this.DefaultStyleKey = typeof(StackedColumnChart);
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