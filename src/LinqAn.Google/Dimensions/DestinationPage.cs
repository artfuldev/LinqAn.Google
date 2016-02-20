namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The page the user immediately visited after performing an internal search on your site. (Usually the search results
    ///     page).
    /// </summary>
    public class DestinationPage : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DestinationPage" />.
        /// </summary>
        public DestinationPage()
            : base(
                "Destination Page",
                "The page the user immediately visited after performing an internal search on your site. (Usually the search results page).",
                false, "ga:searchDestinationPage")
        {
        }
    }
}