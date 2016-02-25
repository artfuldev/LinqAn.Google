using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 44 refers the number/index of the custom metric. Note that the data type of ga:metric44 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 44 refers the number/index of the custom metric. Note that the data type of ga:metric44 can be INTEGER, CURRENCY or TIME.")]
	public class Metric44: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric44" />.
		/// </summary>
		public Metric44(): base("Custom Metric 44 Value",true,"ga:metric44")
		{
			
		}
	}
}

