using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 19 refers the number/index of the custom metric. Note that the data type of ga:metric19 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 19 refers the number/index of the custom metric. Note that the data type of ga:metric19 can be INTEGER, CURRENCY or TIME.")]
	public class Metric19: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric19" />.
		/// </summary>
		public Metric19(): base("Custom Metric 19 Value",true,"ga:metric19")
		{
			
		}
	}
}

