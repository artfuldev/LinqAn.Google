using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average goal value of a session.
	/// </summary>
	[Description("The average goal value of a session.")]
	public class GoalValuePerSession: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalValuePerSession" />.
		/// </summary>
		public GoalValuePerSession(): base("Per Session Goal Value",false,"ga:goalValuePerSession")
		{
			
		}
	}
}

