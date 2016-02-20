namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Combined values of ga:date and ga:hour.
    /// </summary>
    public class HourOfDay : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="HourOfDay" />.
        /// </summary>
        public HourOfDay() : base("Hour of Day", "Combined values of ga:date and ga:hour.", false, "ga:dateHour")
        {
        }
    }
}