namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The title of a page. Keep in mind that multiple pages might have the same page title.
    /// </summary>
    public class PageTitle : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="PageTitle" />.
        /// </summary>
        public PageTitle()
            : base(
                "Page Title", "The title of a page. Keep in mind that multiple pages might have the same page title.",
                true, "ga:pageTitle")
        {
        }
    }
}