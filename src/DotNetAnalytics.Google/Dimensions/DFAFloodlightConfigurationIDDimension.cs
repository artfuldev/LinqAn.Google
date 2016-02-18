namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight configuration ID associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAFloodlightConfigurationIDDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAFloodlightConfigurationIDDimension" />.
        /// </summary>
        public DFAFloodlightConfigurationIDDimension()
            : base(
                "DFA Floodlight Configuration ID",
                "DCM Floodlight configuration ID associated with the floodlight conversion (premium only).", false,
                "ga:dcmFloodlightSpotId")
        {
        }
    }
}