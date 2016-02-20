namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in
    ///     the date range is 0, 1 for the next minute, and so on.
    /// </summary>
    public class MinuteIndex : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MinuteIndex" />.
        /// </summary>
        public MinuteIndex()
            : base(
                "Minute Index",
                "Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.",
                false, "ga:nthMinute")
        {
        }
    }
}