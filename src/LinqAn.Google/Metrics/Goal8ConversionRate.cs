using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal8ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal8ConversionRate" />.
		/// </summary>
		public Goal8ConversionRate(): base("Goal 8 Conversion Rate",false,"ga:goal8ConversionRate")
		{
			
		}
	}
}

