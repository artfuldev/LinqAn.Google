using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal9ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal9ConversionRate" />.
		/// </summary>
		public Goal9ConversionRate(): base("Goal 9 Conversion Rate",false,"ga:goal9ConversionRate")
		{
			
		}
	}
}

