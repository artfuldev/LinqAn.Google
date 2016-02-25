using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal19ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal19ConversionRate" />.
		/// </summary>
		public Goal19ConversionRate(): base("Goal 19 Conversion Rate",false,"ga:goal19ConversionRate")
		{
			
		}
	}
}

