using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal17ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal17ConversionRate" />.
		/// </summary>
		public Goal17ConversionRate(): base("Goal 17 Conversion Rate",false,"ga:goal17ConversionRate")
		{
			
		}
	}
}

