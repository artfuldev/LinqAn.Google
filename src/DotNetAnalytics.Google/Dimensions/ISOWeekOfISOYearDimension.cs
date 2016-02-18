namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Combined values of ga:isoYear and ga:isoWeek.
    /// </summary>
    public class ISOWeekOfISOYearDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ISOWeekOfISOYearDimension" />.
        /// </summary>
        public ISOWeekOfISOYearDimension()
            : base("ISO Week of ISO Year", "Combined values of ga:isoYear and ga:isoWeek.", false, "ga:isoYearIsoWeek")
        {
        }
    }
}