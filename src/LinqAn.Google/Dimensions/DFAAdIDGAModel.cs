namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM ad ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdIDGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdIDGAModel" />.
        /// </summary>
        public DFAAdIDGAModel()
            : base(
                "DFA Ad ID (GA Model)",
                "DCM ad ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAdId")
        {
        }
    }
}