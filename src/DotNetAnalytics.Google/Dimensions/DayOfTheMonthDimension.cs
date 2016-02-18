namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The day of the month. A two-digit number from 01 to 31.
    /// </summary>
    public class DayOfTheMonthDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DayOfTheMonthDimension" />.
        /// </summary>
        public DayOfTheMonthDimension()
            : base("Day of the month", "The day of the month. A two-digit number from 01 to 31.", false, "ga:day")
        {
        }
    }
}