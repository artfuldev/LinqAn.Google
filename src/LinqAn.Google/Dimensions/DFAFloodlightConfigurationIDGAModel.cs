namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAFloodlightConfigurationIDGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAFloodlightConfigurationIDGAModel" />.
        /// </summary>
        public DFAFloodlightConfigurationIDGAModel()
            : base(
                "DFA Floodlight Configuration ID (GA Model)",
                "DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only).",
                false, "ga:dcmClickSpotId")
        {
        }
    }
}