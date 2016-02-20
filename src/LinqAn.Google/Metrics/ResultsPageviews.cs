namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of times a search result page was viewed after performing a search.
    /// </summary>
    public class ResultsPageviews : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ResultsPageviews" />.
        /// </summary>
        public ResultsPageviews()
            : base(
                "Results Pageviews", "The number of times a search result page was viewed after performing a search.",
                false, "ga:searchResultViews")
        {
        }
    }
}