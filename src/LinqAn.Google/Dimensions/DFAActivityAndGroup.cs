namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight activity name and group name associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAActivityAndGroup : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAActivityAndGroup" />.
        /// </summary>
        public DFAActivityAndGroup()
            : base(
                "DFA Activity and Group",
                "DCM Floodlight activity name and group name associated with the floodlight conversion (premium only).",
                false, "ga:dcmFloodlightActivityAndGroup")
        {
        }
    }
}