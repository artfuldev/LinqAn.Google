using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal5ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal5ConversionRate" />.
		/// </summary>
		public Goal5ConversionRate(): base("Goal 5 Conversion Rate",false,"ga:goal5ConversionRate")
		{
			
		}
	}
}

