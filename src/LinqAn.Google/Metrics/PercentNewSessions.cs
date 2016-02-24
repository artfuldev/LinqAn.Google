using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions by people who had never visited your property before.
	/// </summary>
	[Description("The percentage of sessions by people who had never visited your property before.")]
	public class PercentNewSessions: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PercentNewSessions" />.
		/// </summary>
		public PercentNewSessions(): base("% New Sessions",false,"ga:percentNewSessions")
		{
			
		}
	}
}

