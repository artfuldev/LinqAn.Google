namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFACampaignIDDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACampaignIDDFAModel" />.
        /// </summary>
        public DFACampaignIDDFAModel()
            : base(
                "DFA Campaign ID (DFA Model)",
                "DCM campaign ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventCampaignId")
        {
        }
    }
}