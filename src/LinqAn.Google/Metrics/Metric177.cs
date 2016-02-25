using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 177 refers the number/index of the custom metric. Note that the data type of ga:metric177 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 177 refers the number/index of the custom metric. Note that the data type of ga:metric177 can be INTEGER, CURRENCY or TIME.")]
	public class Metric177: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric177" />.
		/// </summary>
		public Metric177(): base("Custom Metric 177 Value",true,"ga:metric177")
		{
			
		}
	}
}

