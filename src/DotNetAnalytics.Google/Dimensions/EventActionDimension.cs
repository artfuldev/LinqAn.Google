namespace DotNetAnalytics.Google.Dimensions
{
	public class EventActionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The action of the event.
		/// </summary>
		public EventActionDimension(): base("Event Action","The action of the event.",true,"ga:eventAction")
		{
			
		}
	}
}

