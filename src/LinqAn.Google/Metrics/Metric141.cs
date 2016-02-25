using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 141 refers the number/index of the custom metric. Note that the data type of ga:metric141 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 141 refers the number/index of the custom metric. Note that the data type of ga:metric141 can be INTEGER, CURRENCY or TIME.")]
	public class Metric141: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric141" />.
		/// </summary>
		public Metric141(): base("Custom Metric 141 Value",true,"ga:metric141")
		{
			
		}
	}
}

