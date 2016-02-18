namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight activity group name associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAActivityGroupDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAActivityGroupDimension" />.
        /// </summary>
        public DFAActivityGroupDimension()
            : base(
                "DFA Activity Group",
                "DCM Floodlight activity group name associated with the floodlight conversion (premium only).", false,
                "ga:dcmFloodlightActivityGroup")
        {
        }
    }
}