namespace ModernUICharts
{

    public class RadialGaugeChart : ChartBase
    {
        #region Constructors

        /// <summary>
        /// Initializes the <see cref="PieChart"/> class.
        /// </summary>
        static RadialGaugeChart()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PieChart"/> class.
        /// </summary>
        public RadialGaugeChart()
        {
            this.DefaultStyleKey = typeof(RadialGaugeChart);
        }

        #endregion Constructors

        protected override double GridLinesMaxValue
        {
            get
            {
                return 0.0;
            }
        }
    }
}