using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions with search.
	/// </summary>
	[Description("The percentage of sessions with search.")]
	public class PercentSessionsWithSearch: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PercentSessionsWithSearch" />.
		/// </summary>
		public PercentSessionsWithSearch(): base("% Sessions with Search",false,"ga:percentSessionsWithSearch")
		{
			
		}
	}
}

