namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM creative name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeGAModel" />.
        /// </summary>
        public DFACreativeGAModel()
            : base(
                "DFA Creative (GA Model)",
                "DCM creative name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickCreative")
        {
        }
    }
}