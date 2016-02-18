namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The browser size used by users to your website. For example, 1024x768.
    /// </summary>
    public class BrowserSizeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="BrowserSizeDimension" />.
        /// </summary>
        public BrowserSizeDimension()
            : base(
                "Browser Size", "The browser size used by users to your website. For example, 1024x768.", true,
                "ga:browserSize")
        {
        }
    }
}