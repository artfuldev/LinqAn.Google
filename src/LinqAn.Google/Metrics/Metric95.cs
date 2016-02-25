using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 95 refers the number/index of the custom metric. Note that the data type of ga:metric95 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 95 refers the number/index of the custom metric. Note that the data type of ga:metric95 can be INTEGER, CURRENCY or TIME.")]
	public class Metric95: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric95" />.
		/// </summary>
		public Metric95(): base("Custom Metric 95 Value",true,"ga:metric95")
		{
			
		}
	}
}

