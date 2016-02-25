using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal1ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal1ConversionRate" />.
		/// </summary>
		public Goal1ConversionRate(): base("Goal 1 Conversion Rate",false,"ga:goal1ConversionRate")
		{
			
		}
	}
}

