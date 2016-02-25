using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal13ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal13ConversionRate" />.
		/// </summary>
		public Goal13ConversionRate(): base("Goal 13 Conversion Rate",false,"ga:goal13ConversionRate")
		{
			
		}
	}
}

