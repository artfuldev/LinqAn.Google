using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The overall number of times users started goals without actually completing them.
	/// </summary>
	[Description("The overall number of times users started goals without actually completing them.")]
	public class GoalAbandonsAll: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalAbandonsAll" />.
		/// </summary>
		public GoalAbandonsAll(): base("Abandoned Funnels",false,"ga:goalAbandonsAll")
		{
			
		}
	}
}

