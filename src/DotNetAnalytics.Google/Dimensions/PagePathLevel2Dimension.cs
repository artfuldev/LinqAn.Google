namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     This dimension rolls up all the page paths in the second hierarchical level in pagePath.
    /// </summary>
    public class PagePathLevel2Dimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PagePathLevel2Dimension" />.
        /// </summary>
        public PagePathLevel2Dimension()
            : base(
                "Page path level 2",
                "This dimension rolls up all the page paths in the second hierarchical level in pagePath.", false,
                "ga:pagePathLevel2")
        {
        }
    }
}