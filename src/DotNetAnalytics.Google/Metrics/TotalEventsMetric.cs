namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of events for the profile, across all categories.
    /// </summary>
    public class TotalEventsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TotalEventsMetric" />.
        /// </summary>
        public TotalEventsMetric()
            : base(
                "Total Events", "The total number of events for the profile, across all categories.", true,
                "ga:totalEvents")
        {
        }
    }
}