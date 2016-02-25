using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal3ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal3ConversionRate" />.
		/// </summary>
		public Goal3ConversionRate(): base("Goal 3 Conversion Rate",false,"ga:goal3ConversionRate")
		{
			
		}
	}
}

