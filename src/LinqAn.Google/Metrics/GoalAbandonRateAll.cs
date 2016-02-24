using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which goals were abandoned.
	/// </summary>
	[Description("The rate at which goals were abandoned.")]
	public class GoalAbandonRateAll: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalAbandonRateAll" />.
		/// </summary>
		public GoalAbandonRateAll(): base("Total Abandonment Rate",false,"ga:goalAbandonRateAll")
		{
			
		}
	}
}

