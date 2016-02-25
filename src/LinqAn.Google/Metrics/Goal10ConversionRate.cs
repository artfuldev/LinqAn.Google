using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal10ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal10ConversionRate" />.
		/// </summary>
		public Goal10ConversionRate(): base("Goal 10 Conversion Rate",false,"ga:goal10ConversionRate")
		{
			
		}
	}
}

