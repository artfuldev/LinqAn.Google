namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM ad type ID of the DCM click matching the Google Analytics session (premium only).
    /// </summary>
    public class DFAAdTypeID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAAdTypeID" />.
        /// </summary>
        public DFAAdTypeID()
            : base(
                "DFA Ad Type ID",
                "DCM ad type ID of the DCM click matching the Google Analytics session (premium only).", false,
                "ga:dcmClickAdTypeId")
        {
        }
    }
}