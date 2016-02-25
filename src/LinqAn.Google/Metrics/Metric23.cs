using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 23 refers the number/index of the custom metric. Note that the data type of ga:metric23 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 23 refers the number/index of the custom metric. Note that the data type of ga:metric23 can be INTEGER, CURRENCY or TIME.")]
	public class Metric23: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric23" />.
		/// </summary>
		public Metric23(): base("Custom Metric 23 Value",true,"ga:metric23")
		{
			
		}
	}
}

