namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeTypeIDDFAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeTypeIDDFAModelDimension" />.
        /// </summary>
        public DFACreativeTypeIDDFAModelDimension()
            : base(
                "DFA Creative Type ID (DFA Model)",
                "DCM creative type ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventCreativeTypeId")
        {
        }
    }
}