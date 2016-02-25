using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 119 refers the number/index of the custom metric. Note that the data type of ga:metric119 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 119 refers the number/index of the custom metric. Note that the data type of ga:metric119 can be INTEGER, CURRENCY or TIME.")]
	public class Metric119: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric119" />.
		/// </summary>
		public Metric119(): base("Custom Metric 119 Value",true,"ga:metric119")
		{
			
		}
	}
}

