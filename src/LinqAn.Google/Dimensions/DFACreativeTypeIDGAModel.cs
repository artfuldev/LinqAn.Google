namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM creative type ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeTypeIDGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeTypeIDGAModel" />.
        /// </summary>
        public DFACreativeTypeIDGAModel()
            : base(
                "DFA Creative Type ID (GA Model)",
                "DCM creative type ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCreativeTypeId")
        {
        }
    }
}