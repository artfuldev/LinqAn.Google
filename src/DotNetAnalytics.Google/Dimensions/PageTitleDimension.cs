namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The title of a page. Keep in mind that multiple pages might have the same page title.
    /// </summary>
    public class PageTitleDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PageTitleDimension" />.
        /// </summary>
        public PageTitleDimension()
            : base(
                "Page Title", "The title of a page. Keep in mind that multiple pages might have the same page title.",
                true, "ga:pageTitle")
        {
        }
    }
}