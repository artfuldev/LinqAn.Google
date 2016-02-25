using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 70 refers the number/index of the custom metric. Note that the data type of ga:metric70 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 70 refers the number/index of the custom metric. Note that the data type of ga:metric70 can be INTEGER, CURRENCY or TIME.")]
	public class Metric70: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric70" />.
		/// </summary>
		public Metric70(): base("Custom Metric 70 Value",true,"ga:metric70")
		{
			
		}
	}
}

