using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal20ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal20ConversionRate" />.
		/// </summary>
		public Goal20ConversionRate(): base("Goal 20 Conversion Rate",false,"ga:goal20ConversionRate")
		{
			
		}
	}
}

