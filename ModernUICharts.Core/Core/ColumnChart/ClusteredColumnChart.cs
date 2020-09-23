namespace ModernUICharts
{
    /// <summary>
    /// Represents an Instance of the bar-chart
    /// </summary>
    public class ClusteredColumnChart : ChartBase
    {
      

        #region Constructors

        /// <summary>
        /// Initializes the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        static ClusteredColumnChart()        
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteredColumnChart"/> class.
        /// </summary>
        public ClusteredColumnChart()
        {
            this.DefaultStyleKey = typeof(ClusteredColumnChart);
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