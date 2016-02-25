using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal4ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal4ConversionRate" />.
		/// </summary>
		public Goal4ConversionRate(): base("Goal 4 Conversion Rate",false,"ga:goal4ConversionRate")
		{
			
		}
	}
}

