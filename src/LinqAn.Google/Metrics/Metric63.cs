using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 63 refers the number/index of the custom metric. Note that the data type of ga:metric63 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 63 refers the number/index of the custom metric. Note that the data type of ga:metric63 can be INTEGER, CURRENCY or TIME.")]
	public class Metric63: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric63" />.
		/// </summary>
		public Metric63(): base("Custom Metric 63 Value",true,"ga:metric63")
		{
			
		}
	}
}

