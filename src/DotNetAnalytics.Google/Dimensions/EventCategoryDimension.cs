namespace DotNetAnalytics.Google.Dimensions
{
	public class EventCategoryDimension: Dimension<string>
	{
		/// <summary>
		/// 	The category of the event.
		/// </summary>
		public EventCategoryDimension(): base("Event Category","The category of the event.",true,"ga:eventCategory")
		{
			
		}
	}
}

