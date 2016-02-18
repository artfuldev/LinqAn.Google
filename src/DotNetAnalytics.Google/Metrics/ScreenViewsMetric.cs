namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of screenviews.
    /// </summary>
    public class ScreenViewsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ScreenViewsMetric" />.
        /// </summary>
        public ScreenViewsMetric() : base("Screen Views", "The total number of screenviews.", true, "ga:screenviews")
        {
        }
    }
}