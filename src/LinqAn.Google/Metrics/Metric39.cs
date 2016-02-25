using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 39 refers the number/index of the custom metric. Note that the data type of ga:metric39 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 39 refers the number/index of the custom metric. Note that the data type of ga:metric39 can be INTEGER, CURRENCY or TIME.")]
	public class Metric39: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric39" />.
		/// </summary>
		public Metric39(): base("Custom Metric 39 Value",true,"ga:metric39")
		{
			
		}
	}
}

