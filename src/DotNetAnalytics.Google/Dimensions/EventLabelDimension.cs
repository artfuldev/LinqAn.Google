namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The label of the event.
	/// </summary>
	public class EventLabelDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="EventLabelDimension" />.
		/// </summary>
		public EventLabelDimension(): base("Event Label","The label of the event.",true,"ga:eventLabel")
		{
			
		}
	}
}

