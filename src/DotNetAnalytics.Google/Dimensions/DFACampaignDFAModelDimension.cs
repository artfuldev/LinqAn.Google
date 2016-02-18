namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFACampaignDFAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACampaignDFAModelDimension" />.
        /// </summary>
        public DFACampaignDFAModelDimension()
            : base(
                "DFA Campaign (DFA Model)",
                "DCM campaign name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventCampaign")
        {
        }
    }
}