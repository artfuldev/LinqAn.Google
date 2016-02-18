namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of subsequent page views made after a use of your internal search feature.
    /// </summary>
    public class SearchDepthMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SearchDepthMetric" />.
        /// </summary>
        public SearchDepthMetric()
            : base(
                "Search Depth",
                "The total number of subsequent page views made after a use of your internal search feature.", true,
                "ga:searchDepth")
        {
        }
    }
}