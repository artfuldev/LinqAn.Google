namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The category of the event.
    /// </summary>
    public class EventCategoryDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="EventCategoryDimension" />.
        /// </summary>
        public EventCategoryDimension() : base("Event Category", "The category of the event.", true, "ga:eventCategory")
        {
        }
    }
}