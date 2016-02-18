namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM ad name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdGAModelDimension" />.
        /// </summary>
        public DFAAdGAModelDimension()
            : base(
                "DFA Ad (GA Model)",
                "DCM ad name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAd")
        {
        }
    }
}