using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 194 refers the number/index of the custom metric. Note that the data type of ga:metric194 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 194 refers the number/index of the custom metric. Note that the data type of ga:metric194 can be INTEGER, CURRENCY or TIME.")]
	public class Metric194: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric194" />.
		/// </summary>
		public Metric194(): base("Custom Metric 194 Value",true,"ga:metric194")
		{
			
		}
	}
}

