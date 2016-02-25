using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 110 refers the number/index of the custom metric. Note that the data type of ga:metric110 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 110 refers the number/index of the custom metric. Note that the data type of ga:metric110 can be INTEGER, CURRENCY or TIME.")]
	public class Metric110: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric110" />.
		/// </summary>
		public Metric110(): base("Custom Metric 110 Value",true,"ga:metric110")
		{
			
		}
	}
}

