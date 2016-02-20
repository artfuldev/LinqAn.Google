namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM campaign name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACampaignGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACampaignGAModel" />.
        /// </summary>
        public DFACampaignGAModel()
            : base(
                "DFA Campaign (GA Model)",
                "DCM campaign name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCampaign")
        {
        }
    }
}