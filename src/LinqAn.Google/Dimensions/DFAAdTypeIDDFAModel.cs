namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM ad type ID of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFAAdTypeIDDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdTypeIDDFAModel" />.
        /// </summary>
        public DFAAdTypeIDDFAModel()
            : base(
                "DFA Ad Type ID (DFA Model)",
                "DCM ad type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventAdTypeId")
        {
        }
    }
}