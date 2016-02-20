namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with
    ///     the Google Analytics session (premium only).
    /// </summary>
    public class DFAPlacementDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAPlacementDFAModel" />.
        /// </summary>
        public DFAPlacementDFAModel()
            : base(
                "DFA Placement (DFA Model)",
                "DCM site placement name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventSitePlacement")
        {
        }
    }
}