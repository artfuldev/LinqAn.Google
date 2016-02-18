namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content
    ///     network are identified as "Content network". Details: https://support.google.com/adwords/answer/2472708?hl=en
    /// </summary>
    public class QueryMatchTypeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QueryMatchTypeDimension" />.
        /// </summary>
        public QueryMatchTypeDimension()
            : base(
                "Query Match Type",
                "The match types applied for the search term the user had input(Phrase, Exact, Broad, etc.). Ads on the content network are identified as \"Content network\". Details: https://support.google.com/adwords/answer/2472708?hl=en",
                false, "ga:adMatchType")
        {
        }
    }
}