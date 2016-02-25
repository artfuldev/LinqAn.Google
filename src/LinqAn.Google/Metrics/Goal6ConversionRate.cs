using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal6ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal6ConversionRate" />.
		/// </summary>
		public Goal6ConversionRate(): base("Goal 6 Conversion Rate",false,"ga:goal6ConversionRate")
		{
			
		}
	}
}

