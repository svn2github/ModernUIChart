namespace ModernUICharts
{
    /// <summary>
    /// Represents an Instance of the bar-chart
    /// </summary>
    public class StackedBar100Chart : ChartBase
    {
        /// <summary>
        /// Initializes the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        static StackedBar100Chart()        
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        public StackedBar100Chart()
        {
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