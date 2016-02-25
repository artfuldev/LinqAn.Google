using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 41 refers the number/index of the custom metric. Note that the data type of ga:metric41 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 41 refers the number/index of the custom metric. Note that the data type of ga:metric41 can be INTEGER, CURRENCY or TIME.")]
	public class Metric41: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric41" />.
		/// </summary>
		public Metric41(): base("Custom Metric 41 Value",true,"ga:metric41")
		{
			
		}
	}
}

