namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session
    ///     (premium only).
    /// </summary>
    public class DFASiteGAModelDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFASiteGAModelDimension" />.
        /// </summary>
        public DFASiteGAModelDimension()
            : base(
                "DFA Site (GA Model)",
                "Site name where the DCM creative was shown and clicked on for the DCM click matching the Google Analytics session (premium only).",
                false, "ga:dcmClickSite")
        {
        }
    }
}