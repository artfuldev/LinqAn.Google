namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM site ID where the DCM creative was shown and clicked on for the last DCM event (impression or click within the
    ///     DCM lookback window) associated with the Google Analytics session (premium only).
    /// </summary>
    public class DFASiteIDDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFASiteIDDFAModel" />.
        /// </summary>
        public DFASiteIDDFAModel()
            : base(
                "DFA Site ID (DFA Model)",
                "DCM site ID where the DCM creative was shown and clicked on for the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventSiteId")
        {
        }
    }
}