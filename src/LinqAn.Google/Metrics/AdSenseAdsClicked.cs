namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of times AdSense ads on your site were clicked.
    /// </summary>
    public class AdSenseAdsClicked : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseAdsClicked" />.
        /// </summary>
        public AdSenseAdsClicked()
            : base(
                "AdSense Ads Clicked", "The number of times AdSense ads on your site were clicked.", true,
                "ga:adsenseAdsClicks")
        {
        }
    }
}