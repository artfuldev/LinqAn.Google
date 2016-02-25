using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal7ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal7ConversionRate" />.
		/// </summary>
		public Goal7ConversionRate(): base("Goal 7 Conversion Rate",false,"ga:goal7ConversionRate")
		{
			
		}
	}
}

