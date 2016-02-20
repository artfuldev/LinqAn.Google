namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The label of the event.
    /// </summary>
    public class EventLabel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="EventLabel" />.
        /// </summary>
        public EventLabel() : base("Event Label", "The label of the event.", true, "ga:eventLabel")
        {
        }
    }
}