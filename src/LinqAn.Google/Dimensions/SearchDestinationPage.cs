namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A page that the user visited after performing an internal search on your site.
    /// </summary>
    public class SearchDestinationPage : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SearchDestinationPage" />.
        /// </summary>
        public SearchDestinationPage()
            : base(
                "Search Destination Page",
                "A page that the user visited after performing an internal search on your site.", true,
                "ga:searchAfterDestinationPage")
        {
        }
    }
}