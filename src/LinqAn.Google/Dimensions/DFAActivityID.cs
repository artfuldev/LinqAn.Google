namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight activity ID associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAActivityID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAActivityID" />.
        /// </summary>
        public DFAActivityID()
            : base(
                "DFA Activity ID",
                "DCM Floodlight activity ID associated with the floodlight conversion (premium only).", false,
                "ga:dcmFloodlightActivityId")
        {
        }
    }
}