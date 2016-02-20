namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight configuration ID associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAFloodlightConfigurationID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAFloodlightConfigurationID" />.
        /// </summary>
        public DFAFloodlightConfigurationID()
            : base(
                "DFA Floodlight Configuration ID",
                "DCM Floodlight configuration ID associated with the floodlight conversion (premium only).", false,
                "ga:dcmFloodlightSpotId")
        {
        }
    }
}