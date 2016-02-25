using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 1 refers the number/index of the custom metric. Note that the data type of ga:metric1 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 1 refers the number/index of the custom metric. Note that the data type of ga:metric1 can be INTEGER, CURRENCY or TIME.")]
	public class Metric1: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric1" />.
		/// </summary>
		public Metric1(): base("Custom Metric 1 Value",true,"ga:metric1")
		{
			
		}
	}
}

