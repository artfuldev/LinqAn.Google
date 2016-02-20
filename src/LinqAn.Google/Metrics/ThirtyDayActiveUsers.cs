namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Total number of 30-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date,
    ///     or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value
    ///     will be the total unique users for the 30 day period ending on the given date.
    /// </summary>
    public class ThirtyDayActiveUsers : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ThirtyDayActiveUsers" />.
        /// </summary>
        public ThirtyDayActiveUsers()
            : base(
                "30 Day Active Users",
                "Total number of 30-day active users for each day in the requested time period. At least one of ga:nthDay, ga:date, or ga:day must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 30 day period ending on the given date.",
                false, "ga:30dayUsers")
        {
        }
    }
}