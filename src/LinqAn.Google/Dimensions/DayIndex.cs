namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0,
    ///     1 for the second day, and so on.
    /// </summary>
    public class DayIndex : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DayIndex" />.
        /// </summary>
        public DayIndex()
            : base(
                "Day Index",
                "Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on.",
                false, "ga:nthDay")
        {
        }
    }
}