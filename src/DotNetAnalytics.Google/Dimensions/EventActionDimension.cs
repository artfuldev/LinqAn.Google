namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The action of the event.
    /// </summary>
    public class EventActionDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="EventActionDimension" />.
        /// </summary>
        public EventActionDimension() : base("Event Action", "The action of the event.", true, "ga:eventAction")
        {
        }
    }
}