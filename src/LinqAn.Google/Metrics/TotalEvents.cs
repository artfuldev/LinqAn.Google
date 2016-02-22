using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of events for the profile, across all categories.
	/// </summary>
	[Description("The total number of events for the profile, across all categories.")]
	public class TotalEvents: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="TotalEvents" />.
		/// </summary>
		public TotalEvents(): base("Total Events",true,"ga:totalEvents")
		{
			
		}
	}
}

