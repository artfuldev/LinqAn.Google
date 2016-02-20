namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM ad type name of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdTypeGAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdTypeGAModel" />.
        /// </summary>
        public DFAAdTypeGAModel()
            : base(
                "DFA Ad Type (GA Model)",
                "DCM ad type name of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAdType")
        {
        }
    }
}