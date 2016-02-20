namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The number of words in the search query.
    /// </summary>
    public class QueryWordCount : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QueryWordCount" />.
        /// </summary>
        public QueryWordCount()
            : base("Query Word Count", "The number of words in the search query.", false, "ga:adQueryWordCount")
        {
        }
    }
}