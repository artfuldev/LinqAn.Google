namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM campaign name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACampaignGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACampaignGAModelDimension" />.
        /// </summary>
        public DFACampaignGAModelDimension()
            : base(
                "DFA Campaign (GA Model)",
                "DCM campaign name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCampaign")
        {
        }
    }
}