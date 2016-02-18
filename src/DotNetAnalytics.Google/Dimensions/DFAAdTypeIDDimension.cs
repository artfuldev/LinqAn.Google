namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     DCM ad type ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdTypeIDDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdTypeIDDimension" />.
        /// </summary>
        public DFAAdTypeIDDimension()
            : base(
                "DFA Ad Type ID",
                "DCM ad type ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAdTypeId")
        {
        }
    }
}