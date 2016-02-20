namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM ad ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google
    ///     Analytics session (premium only).
    /// </summary>
    public class DFAAdIDDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdIDDFAModel" />.
        /// </summary>
        public DFAAdIDDFAModel()
            : base(
                "DFA Ad ID (DFA Model)",
                "DCM ad ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventAdId")
        {
        }
    }
}