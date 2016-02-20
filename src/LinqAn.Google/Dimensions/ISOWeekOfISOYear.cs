namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Combined values of ga:isoYear and ga:isoWeek.
    /// </summary>
    public class ISOWeekOfISOYear : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ISOWeekOfISOYear" />.
        /// </summary>
        public ISOWeekOfISOYear()
            : base("ISO Week of ISO Year", "Combined values of ga:isoYear and ga:isoWeek.", false, "ga:isoYearIsoWeek")
        {
        }
    }
}