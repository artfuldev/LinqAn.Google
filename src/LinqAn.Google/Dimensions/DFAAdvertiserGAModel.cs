namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM advertiser name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdvertiserGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdvertiserGAModel" />.
        /// </summary>
        public DFAAdvertiserGAModel()
            : base(
                "DFA Advertiser (GA Model)",
                "DCM advertiser name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAdvertiser")
        {
        }
    }
}