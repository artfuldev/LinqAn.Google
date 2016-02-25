using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal11ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal11ConversionRate" />.
		/// </summary>
		public Goal11ConversionRate(): base("Goal 11 Conversion Rate",false,"ga:goal11ConversionRate")
		{
			
		}
	}
}

