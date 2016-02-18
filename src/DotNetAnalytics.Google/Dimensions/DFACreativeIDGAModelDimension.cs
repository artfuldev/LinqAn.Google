namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM creative ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeIDGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeIDGAModelDimension" />.
        /// </summary>
        public DFACreativeIDGAModelDimension()
            : base(
                "DFA Creative ID (GA Model)",
                "DCM creative ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCreativeId")
        {
        }
    }
}