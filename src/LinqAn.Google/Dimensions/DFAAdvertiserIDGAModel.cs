namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdvertiserIDGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdvertiserIDGAModel" />.
        /// </summary>
        public DFAAdvertiserIDGAModel()
            : base(
                "DFA Advertiser ID (GA Model)",
                "DCM advertiser ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAdvertiserId")
        {
        }
    }
}