using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total numeric value for all goals defined for your profile.
	/// </summary>
	[Description("The total numeric value for all goals defined for your profile.")]
	public class GoalValueAll: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalValueAll" />.
		/// </summary>
		public GoalValueAll(): base("Goal Value",true,"ga:goalValueAll")
		{
			
		}
	}
}

