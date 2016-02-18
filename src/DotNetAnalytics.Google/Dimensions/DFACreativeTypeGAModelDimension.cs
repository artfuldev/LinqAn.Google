namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM creative type name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeTypeGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeTypeGAModelDimension" />.
        /// </summary>
        public DFACreativeTypeGAModelDimension()
            : base(
                "DFA Creative Type (GA Model)",
                "DCM creative type name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCreativeType")
        {
        }
    }
}