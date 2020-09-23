namespace ModernUICharts
{
    /// <summary>
    /// Represents an Instance of the bar-chart
    /// </summary>
    public class StackedColumn100Chart : ChartBase
    {
        /// <summary>
        /// Initializes the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        static StackedColumn100Chart()        
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        public StackedColumn100Chart()
        {
            this.DefaultStyleKey = typeof(StackedColumn100Chart);
        }

        protected override double GridLinesMaxValue
        {
            get
            {
                return 100.0;
            }
        }
    }
}