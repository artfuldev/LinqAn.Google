namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     A page that the user visited after performing an internal search on your site.
    /// </summary>
    public class SearchDestinationPageDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SearchDestinationPageDimension" />.
        /// </summary>
        public SearchDestinationPageDimension()
            : base(
                "Search Destination Page",
                "A page that the user visited after performing an internal search on your site.", true,
                "ga:searchAfterDestinationPage")
        {
        }
    }
}