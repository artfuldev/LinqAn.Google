using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal18ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal18ConversionRate" />.
		/// </summary>
		public Goal18ConversionRate(): base("Goal 18 Conversion Rate",false,"ga:goal18ConversionRate")
		{
			
		}
	}
}

