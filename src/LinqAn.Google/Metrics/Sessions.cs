using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions.
	/// </summary>
	[Description("The total number of sessions.")]
	public class Sessions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Sessions" />.
		/// </summary>
		public Sessions(): base("Sessions",true,"ga:sessions")
		{
			
		}
	}
}

