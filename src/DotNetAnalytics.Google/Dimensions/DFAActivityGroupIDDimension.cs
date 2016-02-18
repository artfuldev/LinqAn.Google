namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight activity group ID associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAActivityGroupIDDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAActivityGroupIDDimension" />.
        /// </summary>
        public DFAActivityGroupIDDimension()
            : base(
                "DFA Activity Group ID",
                "DCM Floodlight activity group ID associated with the floodlight conversion (premium only).", false,
                "ga:dcmFloodlightActivityGroupId")
        {
        }
    }
}