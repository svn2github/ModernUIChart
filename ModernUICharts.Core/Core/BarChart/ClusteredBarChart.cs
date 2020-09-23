namespace ModernUICharts
{
    /// <summary>
    /// Represents an Instance of the bar-chart
    /// </summary>
    public class ClusteredBarChart : ChartBase
    {
        #region Constructors

        /// <summary>
        /// Initializes the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        static ClusteredBarChart()        
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        public ClusteredBarChart()
        {
        }

        #endregion Constructors

        protected override double GridLinesMaxValue
        {
            get
            {
                return MaxDataPointValue;
            }
        }

        protected override void OnMaxDataPointValueChanged(double p)
        {
            UpdateGridLines();
        }

        public override bool IsUseNextBiggestMaxValue
        {
            get
            {
                return true;
            }
        }
    }
}