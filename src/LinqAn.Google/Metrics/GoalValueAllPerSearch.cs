using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average goal value of a search.
	/// </summary>
	[Description("The average goal value of a search.")]
	public class GoalValueAllPerSearch: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalValueAllPerSearch" />.
		/// </summary>
		public GoalValueAllPerSearch(): base("Per Search Goal Value",false,"ga:goalValueAllPerSearch")
		{
			
		}
	}
}

