using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 117 refers the number/index of the custom metric. Note that the data type of ga:metric117 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 117 refers the number/index of the custom metric. Note that the data type of ga:metric117 can be INTEGER, CURRENCY or TIME.")]
	public class Metric117: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric117" />.
		/// </summary>
		public Metric117(): base("Custom Metric 117 Value",true,"ga:metric117")
		{
			
		}
	}
}

