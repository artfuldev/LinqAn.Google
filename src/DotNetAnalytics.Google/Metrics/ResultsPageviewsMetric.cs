namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The number of times a search result page was viewed after performing a search.
    /// </summary>
    public class ResultsPageviewsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ResultsPageviewsMetric" />.
        /// </summary>
        public ResultsPageviewsMetric()
            : base(
                "Results Pageviews", "The number of times a search result page was viewed after performing a search.",
                false, "ga:searchResultViews")
        {
        }
    }
}