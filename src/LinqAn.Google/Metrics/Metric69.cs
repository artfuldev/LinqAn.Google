using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 69 refers the number/index of the custom metric. Note that the data type of ga:metric69 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 69 refers the number/index of the custom metric. Note that the data type of ga:metric69 can be INTEGER, CURRENCY or TIME.")]
	public class Metric69: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric69" />.
		/// </summary>
		public Metric69(): base("Custom Metric 69 Value",true,"ga:metric69")
		{
			
		}
	}
}

