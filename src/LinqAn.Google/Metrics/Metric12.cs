using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 12 refers the number/index of the custom metric. Note that the data type of ga:metric12 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 12 refers the number/index of the custom metric. Note that the data type of ga:metric12 can be INTEGER, CURRENCY or TIME.")]
	public class Metric12: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric12" />.
		/// </summary>
		public Metric12(): base("Custom Metric 12 Value",true,"ga:metric12")
		{
			
		}
	}
}

