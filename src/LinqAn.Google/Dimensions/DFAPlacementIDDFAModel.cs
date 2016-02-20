namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with
    ///     the Google Analytics session (premium only).
    /// </summary>
    public class DFAPlacementIDDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAPlacementIDDFAModel" />.
        /// </summary>
        public DFAPlacementIDDFAModel()
            : base(
                "DFA Placement ID (DFA Model)",
                "DCM site placement ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventSitePlacementId")
        {
        }
    }
}