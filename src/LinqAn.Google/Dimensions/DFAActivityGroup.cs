namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight activity group name associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAActivityGroup : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAActivityGroup" />.
        /// </summary>
        public DFAActivityGroup()
            : base(
                "DFA Activity Group",
                "DCM Floodlight activity group name associated with the floodlight conversion (premium only).", false,
                "ga:dcmFloodlightActivityGroup")
        {
        }
    }
}