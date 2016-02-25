using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 90 refers the number/index of the custom metric. Note that the data type of ga:metric90 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 90 refers the number/index of the custom metric. Note that the data type of ga:metric90 can be INTEGER, CURRENCY or TIME.")]
	public class Metric90: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric90" />.
		/// </summary>
		public Metric90(): base("Custom Metric 90 Value",true,"ga:metric90")
		{
			
		}
	}
}

