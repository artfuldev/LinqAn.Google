namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session
    ///     (premium only).
    /// </summary>
    public class DFASiteGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFASiteGAModel" />.
        /// </summary>
        public DFASiteGAModel()
            : base(
                "DFA Site (GA Model)",
                "Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).",
                false, "ga:dcmClickSite")
        {
        }
    }
}