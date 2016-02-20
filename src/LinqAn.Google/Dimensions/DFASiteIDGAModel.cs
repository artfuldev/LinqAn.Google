namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session
    ///     (premium only).
    /// </summary>
    public class DFASiteIDGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFASiteIDGAModel" />.
        /// </summary>
        public DFASiteIDGAModel()
            : base(
                "DFA Site ID (GA Model)",
                "DCM site ID where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).",
                false, "ga:dcmClickSiteId")
        {
        }
    }
}