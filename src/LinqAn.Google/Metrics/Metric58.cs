using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 58 refers the number/index of the custom metric. Note that the data type of ga:metric58 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 58 refers the number/index of the custom metric. Note that the data type of ga:metric58 can be INTEGER, CURRENCY or TIME.")]
	public class Metric58: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric58" />.
		/// </summary>
		public Metric58(): base("Custom Metric 58 Value",true,"ga:metric58")
		{
			
		}
	}
}

