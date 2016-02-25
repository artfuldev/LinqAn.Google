using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 27 refers the number/index of the custom metric. Note that the data type of ga:metric27 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 27 refers the number/index of the custom metric. Note that the data type of ga:metric27 can be INTEGER, CURRENCY or TIME.")]
	public class Metric27: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric27" />.
		/// </summary>
		public Metric27(): base("Custom Metric 27 Value",true,"ga:metric27")
		{
			
		}
	}
}

