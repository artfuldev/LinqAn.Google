namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Combined values of ga:year and ga:week.
    /// </summary>
    public class WeekOfYearDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="WeekOfYearDimension" />.
        /// </summary>
        public WeekOfYearDimension()
            : base("Week of Year", "Combined values of ga:year and ga:week.", false, "ga:yearWeek")
        {
        }
    }
}