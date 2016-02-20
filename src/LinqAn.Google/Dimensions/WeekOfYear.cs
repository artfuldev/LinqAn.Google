namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Combined values of ga:year and ga:week.
    /// </summary>
    public class WeekOfYear : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="WeekOfYear" />.
        /// </summary>
        public WeekOfYear() : base("Week of Year", "Combined values of ga:year and ga:week.", false, "ga:yearWeek")
        {
        }
    }
}