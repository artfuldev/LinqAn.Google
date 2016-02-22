using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of unique events. Events in different sessions count as separate events.
	/// </summary>
	[Description("The number of unique events. Events in different sessions count as separate events.")]
	public class UniqueEvents: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UniqueEvents" />.
		/// </summary>
		public UniqueEvents(): base("Unique Events",false,"ga:uniqueEvents")
		{
			
		}
	}
}

