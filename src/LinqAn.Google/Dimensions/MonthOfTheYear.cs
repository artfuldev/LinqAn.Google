namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The month of the session. A two digit integer from 01 to 12.
    /// </summary>
    public class MonthOfTheYear : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="MonthOfTheYear" />.
        /// </summary>
        public MonthOfTheYear()
            : base(
                "Month of the year", "The month of the session. A two digit integer from 01 to 12.", false, "ga:month")
        {
        }
    }
}