using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of sessions which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of sessions which resulted in a conversion to the requested goal number.")]
	public class Goal12ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal12ConversionRate" />.
		/// </summary>
		public Goal12ConversionRate(): base("Goal 12 Conversion Rate",false,"ga:goal12ConversionRate")
		{
			
		}
	}
}

