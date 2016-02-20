namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of times users have clicked on an ad to reach your property.
    /// </summary>
    public class Clicks : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Clicks" />.
        /// </summary>
        public Clicks()
            : base(
                "Clicks", "The total number of times users have clicked on an ad to reach your property.", false,
                "ga:adClicks")
        {
        }
    }
}