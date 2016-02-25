using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 172 refers the number/index of the custom metric. Note that the data type of ga:metric172 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 172 refers the number/index of the custom metric. Note that the data type of ga:metric172 can be INTEGER, CURRENCY or TIME.")]
	public class Metric172: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric172" />.
		/// </summary>
		public Metric172(): base("Custom Metric 172 Value",true,"ga:metric172")
		{
			
		}
	}
}

