using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 99 refers the number/index of the custom metric. Note that the data type of ga:metric99 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 99 refers the number/index of the custom metric. Note that the data type of ga:metric99 can be INTEGER, CURRENCY or TIME.")]
	public class Metric99: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric99" />.
		/// </summary>
		public Metric99(): base("Custom Metric 99 Value",true,"ga:metric99")
		{
			
		}
	}
}

