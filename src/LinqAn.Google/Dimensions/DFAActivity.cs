namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM Floodlight activity name associated with the floodlight conversion (premium only).
    /// </summary>
    public class DFAActivity : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAActivity" />.
        /// </summary>
        public DFAActivity()
            : base(
                "DFA Activity", "DCM Floodlight activity name associated with the floodlight conversion (premium only).",
                false, "ga:dcmFloodlightActivity")
        {
        }
    }
}