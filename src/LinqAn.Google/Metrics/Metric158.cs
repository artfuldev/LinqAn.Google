using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 158 refers the number/index of the custom metric. Note that the data type of ga:metric158 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 158 refers the number/index of the custom metric. Note that the data type of ga:metric158 can be INTEGER, CURRENCY or TIME.")]
	public class Metric158: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric158" />.
		/// </summary>
		public Metric158(): base("Custom Metric 158 Value",true,"ga:metric158")
		{
			
		}
	}
}

