namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM creative name of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeDFAModel" />.
        /// </summary>
        public DFACreativeDFAModel()
            : base(
                "DFA Creative (DFA Model)",
                "DCM creative name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventCreative")
        {
        }
    }
}