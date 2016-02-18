namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAFloodlightConfigurationIDGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAFloodlightConfigurationIDGAModelDimension" />.
        /// </summary>
        public DFAFloodlightConfigurationIDGAModelDimension()
            : base(
                "DFA Floodlight Configuration ID (GA Model)",
                "DCM Floodlight configuration ID of the DCM click matching the Google Analytics session (premium only).",
                false, "ga:dcmClickSpotId")
        {
        }
    }
}