using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal14ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal14ConversionRate" />.
		/// </summary>
		public Goal14ConversionRate(): base("Goal 14 Conversion Rate",false,"ga:goal14ConversionRate")
		{
			
		}
	}
}

