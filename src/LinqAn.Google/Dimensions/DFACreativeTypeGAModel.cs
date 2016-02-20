namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM creative type name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeTypeGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeTypeGAModel" />.
        /// </summary>
        public DFACreativeTypeGAModel()
            : base(
                "DFA Creative Type (GA Model)",
                "DCM creative type name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCreativeType")
        {
        }
    }
}