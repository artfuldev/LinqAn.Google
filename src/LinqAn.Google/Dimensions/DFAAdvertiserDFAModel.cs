namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM advertiser name of the last DCM event (impression or click within the DCM lookback window) associated with the
    ///     Google Analytics session (premium only).
    /// </summary>
    public class DFAAdvertiserDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdvertiserDFAModel" />.
        /// </summary>
        public DFAAdvertiserDFAModel()
            : base(
                "DFA Advertiser (DFA Model)",
                "DCM advertiser name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventAdvertiser")
        {
        }
    }
}