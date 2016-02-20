namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM creative version of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeVersionGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeVersionGAModel" />.
        /// </summary>
        public DFACreativeVersionGAModel()
            : base(
                "DFA Creative Version (GA Model)",
                "DCM creative version of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCreativeVersion")
        {
        }
    }
}