namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The browser versions used by users to your website. For example, 2.0.0.14
    /// </summary>
    public class BrowserVersion : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="BrowserVersion" />.
        /// </summary>
        public BrowserVersion()
            : base(
                "Browser Version", "The browser versions used by users to your website. For example, 2.0.0.14", true,
                "ga:browserVersion")
        {
        }
    }
}