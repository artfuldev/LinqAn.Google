using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 140 refers the number/index of the custom metric. Note that the data type of ga:metric140 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 140 refers the number/index of the custom metric. Note that the data type of ga:metric140 can be INTEGER, CURRENCY or TIME.")]
	public class Metric140: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric140" />.
		/// </summary>
		public Metric140(): base("Custom Metric 140 Value",true,"ga:metric140")
		{
			
		}
	}
}

