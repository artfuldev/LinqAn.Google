namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users.
    /// </summary>
    public class RevenuePerUserMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="RevenuePerUserMetric" />.
        /// </summary>
        public RevenuePerUserMetric()
            : base(
                "Revenue per User",
                "The total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users.",
                false, "ga:revenuePerUser")
        {
        }
    }
}