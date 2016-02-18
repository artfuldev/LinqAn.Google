namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The number of days elapsed since users last visited your property. Used to calculate user loyalty.
    /// </summary>
    public class DaysSinceLastSessionDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DaysSinceLastSessionDimension" />.
        /// </summary>
        public DaysSinceLastSessionDimension()
            : base(
                "Days Since Last Session",
                "The number of days elapsed since users last visited your property. Used to calculate user loyalty.",
                true, "ga:daysSinceLastSession")
        {
        }
    }
}