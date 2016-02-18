namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM creative type ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeTypeIDGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeTypeIDGAModelDimension" />.
        /// </summary>
        public DFACreativeTypeIDGAModelDimension()
            : base(
                "DFA Creative Type ID (GA Model)",
                "DCM creative type ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCreativeTypeId")
        {
        }
    }
}