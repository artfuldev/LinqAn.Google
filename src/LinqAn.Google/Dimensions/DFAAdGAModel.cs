namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM ad name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdGAModel" />.
        /// </summary>
        public DFAAdGAModel()
            : base(
                "DFA Ad (GA Model)",
                "DCM ad name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAd")
        {
        }
    }
}