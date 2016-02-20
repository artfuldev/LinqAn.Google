namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).
    /// </summary>
    public class DayOfWeek : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DayOfWeek" />.
        /// </summary>
        public DayOfWeek()
            : base(
                "Day of Week", "The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).", false,
                "ga:dayOfWeek")
        {
        }
    }
}