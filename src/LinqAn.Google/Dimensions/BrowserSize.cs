namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The browser size used by users to your website. For example, 1024x768.
    /// </summary>
    public class BrowserSize : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="BrowserSize" />.
        /// </summary>
        public BrowserSize()
            : base(
                "Browser Size", "The browser size used by users to your website. For example, 1024x768.", true,
                "ga:browserSize")
        {
        }
    }
}