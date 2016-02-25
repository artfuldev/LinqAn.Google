using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 50 refers the number/index of the custom metric. Note that the data type of ga:metric50 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 50 refers the number/index of the custom metric. Note that the data type of ga:metric50 can be INTEGER, CURRENCY or TIME.")]
	public class Metric50: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric50" />.
		/// </summary>
		public Metric50(): base("Custom Metric 50 Value",true,"ga:metric50")
		{
			
		}
	}
}

