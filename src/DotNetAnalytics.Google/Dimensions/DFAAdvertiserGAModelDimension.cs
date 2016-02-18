namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM advertiser name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdvertiserGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdvertiserGAModelDimension" />.
        /// </summary>
        public DFAAdvertiserGAModelDimension()
            : base(
                "DFA Advertiser (GA Model)",
                "DCM advertiser name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAdvertiser")
        {
        }
    }
}