namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight configuration ID of the last DCM event (impression or click within the DCM lookback window)
    ///     associated with the Google Analytics session (premium only).
    /// </summary>
    public class DFAFloodlightConfigurationIDDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAFloodlightConfigurationIDDFAModel" />.
        /// </summary>
        public DFAFloodlightConfigurationIDDFAModel()
            : base(
                "DFA Floodlight Configuration ID (DFA Model)",
                "DCM Floodlight configuration ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventSpotId")
        {
        }
    }
}