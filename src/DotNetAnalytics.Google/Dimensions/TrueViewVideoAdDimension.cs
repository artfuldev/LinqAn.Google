namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.
    /// </summary>
    public class TrueViewVideoAdDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TrueViewVideoAdDimension" />.
        /// </summary>
        public TrueViewVideoAdDimension()
            : base(
                "TrueView Video Ad", "Yes' or 'No' - Indicates whether the ad is an AdWords TrueView video ad.", false,
                "ga:isTrueViewVideoAd")
        {
        }
    }
}