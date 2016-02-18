namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full
    ///     URL of the page.
    /// </summary>
    public class PageDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PageDimension" />.
        /// </summary>
        public PageDimension()
            : base(
                "Page",
                "A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.",
                true, "ga:pagePath")
        {
        }
    }
}