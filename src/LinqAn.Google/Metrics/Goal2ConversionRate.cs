using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal2ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal2ConversionRate" />.
		/// </summary>
		public Goal2ConversionRate(): base("Goal 2 Conversion Rate",false,"ga:goal2ConversionRate")
		{
			
		}
	}
}

