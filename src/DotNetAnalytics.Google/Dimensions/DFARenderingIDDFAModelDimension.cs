namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFARenderingIDDFAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFARenderingIDDFAModelDimension" />.
        /// </summary>
        public DFARenderingIDDFAModelDimension()
            : base(
                "DFA Rendering ID (DFA Model)",
                "DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventRenderingId")
        {
        }
    }
}