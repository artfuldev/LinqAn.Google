namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM creative ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeIDGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeIDGAModel" />.
        /// </summary>
        public DFACreativeIDGAModel()
            : base(
                "DFA Creative ID (GA Model)",
                "DCM creative ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCreativeId")
        {
        }
    }
}