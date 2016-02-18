namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Combined values of ga:year and ga:month.
    /// </summary>
    public class MonthOfYearDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MonthOfYearDimension" />.
        /// </summary>
        public MonthOfYearDimension()
            : base("Month of Year", "Combined values of ga:year and ga:month.", false, "ga:yearMonth")
        {
        }
    }
}