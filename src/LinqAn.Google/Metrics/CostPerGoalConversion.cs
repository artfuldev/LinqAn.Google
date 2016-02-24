using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The cost per goal conversion for your property.
	/// </summary>
	[Description("The cost per goal conversion for your property.")]
	public class CostPerGoalConversion: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CostPerGoalConversion" />.
		/// </summary>
		public CostPerGoalConversion(): base("Cost per Goal Conversion",false,"ga:costPerGoalConversion")
		{
			
		}
	}
}

