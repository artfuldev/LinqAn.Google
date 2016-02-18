namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of pageviews for your property.
    /// </summary>
    public class PageviewsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PageviewsMetric" />.
        /// </summary>
        public PageviewsMetric()
            : base("Pageviews", "The total number of pageviews for your property.", true, "ga:pageviews")
        {
        }
    }
}