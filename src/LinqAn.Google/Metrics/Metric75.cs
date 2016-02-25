using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 75 refers the number/index of the custom metric. Note that the data type of ga:metric75 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 75 refers the number/index of the custom metric. Note that the data type of ga:metric75 can be INTEGER, CURRENCY or TIME.")]
	public class Metric75: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric75" />.
		/// </summary>
		public Metric75(): base("Custom Metric 75 Value",true,"ga:metric75")
		{
			
		}
	}
}

