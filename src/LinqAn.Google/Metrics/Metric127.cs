using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 127 refers the number/index of the custom metric. Note that the data type of ga:metric127 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 127 refers the number/index of the custom metric. Note that the data type of ga:metric127 can be INTEGER, CURRENCY or TIME.")]
	public class Metric127: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric127" />.
		/// </summary>
		public Metric127(): base("Custom Metric 127 Value",true,"ga:metric127")
		{
			
		}
	}
}

