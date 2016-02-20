namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Search terms used by users within your property.
    /// </summary>
    public class SearchTerm : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SearchTerm" />.
        /// </summary>
        public SearchTerm()
            : base("Search Term", "Search terms used by users within your property.", true, "ga:searchKeyword")
        {
        }
    }
}