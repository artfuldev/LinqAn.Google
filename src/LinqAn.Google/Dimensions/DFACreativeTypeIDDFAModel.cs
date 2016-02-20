namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeTypeIDDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeTypeIDDFAModel" />.
        /// </summary>
        public DFACreativeTypeIDDFAModel()
            : base(
                "DFA Creative Type ID (DFA Model)",
                "DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventCreativeTypeId")
        {
        }
    }
}