using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal16ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal16ConversionRate" />.
		/// </summary>
		public Goal16ConversionRate(): base("Goal 16 Conversion Rate",false,"ga:goal16ConversionRate")
		{
			
		}
	}
}

