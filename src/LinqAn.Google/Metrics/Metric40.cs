using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 40 refers the number/index of the custom metric. Note that the data type of ga:metric40 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 40 refers the number/index of the custom metric. Note that the data type of ga:metric40 can be INTEGER, CURRENCY or TIME.")]
	public class Metric40: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric40" />.
		/// </summary>
		public Metric40(): base("Custom Metric 40 Value",true,"ga:metric40")
		{
			
		}
	}
}

