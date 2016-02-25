using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal15ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal15ConversionRate" />.
		/// </summary>
		public Goal15ConversionRate(): base("Goal 15 Conversion Rate",false,"ga:goal15ConversionRate")
		{
			
		}
	}
}

