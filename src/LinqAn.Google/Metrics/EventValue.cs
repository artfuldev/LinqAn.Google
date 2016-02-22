using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total value of events for the profile.
	/// </summary>
	[Description("The total value of events for the profile.")]
	public class EventValue: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="EventValue" />.
		/// </summary>
		public EventValue(): base("Event Value",true,"ga:eventValue")
		{
			
		}
	}
}

