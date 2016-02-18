namespace DotNetAnalytics.Google.Dimensions
{
	public class EventLabelDimension: Dimension<string>
	{
		/// <summary>
		/// 	The label of the event.
		/// </summary>
		public EventLabelDimension(): base("Event Label","The label of the event.",true,"ga:eventLabel")
		{
			
		}
	}
}

