using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 191 refers the number/index of the custom metric. Note that the data type of ga:metric191 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 191 refers the number/index of the custom metric. Note that the data type of ga:metric191 can be INTEGER, CURRENCY or TIME.")]
	public class Metric191: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric191" />.
		/// </summary>
		public Metric191(): base("Custom Metric 191 Value",true,"ga:metric191")
		{
			
		}
	}
}

