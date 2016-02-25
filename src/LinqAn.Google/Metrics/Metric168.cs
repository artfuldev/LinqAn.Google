using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 168 refers the number/index of the custom metric. Note that the data type of ga:metric168 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 168 refers the number/index of the custom metric. Note that the data type of ga:metric168 can be INTEGER, CURRENCY or TIME.")]
	public class Metric168: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric168" />.
		/// </summary>
		public Metric168(): base("Custom Metric 168 Value",true,"ga:metric168")
		{
			
		}
	}
}

