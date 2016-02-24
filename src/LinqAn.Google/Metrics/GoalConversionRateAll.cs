using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to at least one of your goals.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to at least one of your goals.")]
	public class GoalConversionRateAll: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="GoalConversionRateAll" />.
		/// </summary>
		public GoalConversionRateAll(): base("Goal Conversion Rate",false,"ga:goalConversionRateAll")
		{
			
		}
	}
}

