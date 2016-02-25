using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 71 refers the number/index of the custom metric. Note that the data type of ga:metric71 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 71 refers the number/index of the custom metric. Note that the data type of ga:metric71 can be INTEGER, CURRENCY or TIME.")]
	public class Metric71: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric71" />.
		/// </summary>
		public Metric71(): base("Custom Metric 71 Value",true,"ga:metric71")
		{
			
		}
	}
}

