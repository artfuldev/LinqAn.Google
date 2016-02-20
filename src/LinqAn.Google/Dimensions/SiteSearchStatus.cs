namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and
    ///     Visits Without Site Search.
    /// </summary>
    public class SiteSearchStatus : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SiteSearchStatus" />.
        /// </summary>
        public SiteSearchStatus()
            : base(
                "Site Search Status",
                "A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.",
                true, "ga:searchUsed")
        {
        }
    }
}