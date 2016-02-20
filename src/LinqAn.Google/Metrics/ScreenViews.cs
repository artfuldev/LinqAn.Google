namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of screenviews.
    /// </summary>
    public class ScreenViews : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ScreenViews" />.
        /// </summary>
        public ScreenViews() : base("Screen Views", "The total number of screenviews.", true, "ga:screenviews")
        {
        }
    }
}