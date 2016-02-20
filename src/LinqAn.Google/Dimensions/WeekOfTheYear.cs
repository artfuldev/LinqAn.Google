namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The week of the session. A two-digit number from 01 to 53. Each week starts on Sunday.
    /// </summary>
    public class WeekOfTheYear : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="WeekOfTheYear" />.
        /// </summary>
        public WeekOfTheYear()
            : base(
                "Week of the Year",
                "The week of the session. A two-digit number from 01 to 53. Each week starts on Sunday.", false,
                "ga:week")
        {
        }
    }
}