namespace ModernUICharts
{
    public class DoughnutChart : PieChart
    {
        protected override double GridLinesMaxValue
        {
            get
            {
                return 0.0;
            }
        }
    }
}