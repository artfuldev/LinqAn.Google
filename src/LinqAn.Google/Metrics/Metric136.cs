using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 136 refers the number/index of the custom metric. Note that the data type of ga:metric136 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 136 refers the number/index of the custom metric. Note that the data type of ga:metric136 can be INTEGER, CURRENCY or TIME.")]
	public class Metric136: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric136" />.
		/// </summary>
		public Metric136(): base("Custom Metric 136 Value",true,"ga:metric136")
		{
			
		}
	}
}

