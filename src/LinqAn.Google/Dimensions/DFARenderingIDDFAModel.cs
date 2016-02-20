namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFARenderingIDDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFARenderingIDDFAModel" />.
        /// </summary>
        public DFARenderingIDDFAModel()
            : base(
                "DFA Rendering ID (DFA Model)",
                "DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventRenderingId")
        {
        }
    }
}