namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The search queries that triggered impressions of your AdWords ads.
    /// </summary>
    public class MatchedSearchQuery : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MatchedSearchQuery" />.
        /// </summary>
        public MatchedSearchQuery()
            : base(
                "Matched Search Query", "The search queries that triggered impressions of your AdWords ads.", false,
                "ga:adMatchedQuery")
        {
        }
    }
}