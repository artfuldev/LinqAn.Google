using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 198 refers the number/index of the custom metric. Note that the data type of ga:metric198 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 198 refers the number/index of the custom metric. Note that the data type of ga:metric198 can be INTEGER, CURRENCY or TIME.")]
	public class Metric198: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric198" />.
		/// </summary>
		public Metric198(): base("Custom Metric 198 Value",true,"ga:metric198")
		{
			
		}
	}
}

