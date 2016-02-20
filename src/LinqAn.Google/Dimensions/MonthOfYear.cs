namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Combined values of ga:year and ga:month.
    /// </summary>
    public class MonthOfYear : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MonthOfYear" />.
        /// </summary>
        public MonthOfYear() : base("Month of Year", "Combined values of ga:year and ga:month.", false, "ga:yearMonth")
        {
        }
    }
}