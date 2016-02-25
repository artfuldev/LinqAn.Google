using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 101 refers the number/index of the custom metric. Note that the data type of ga:metric101 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 101 refers the number/index of the custom metric. Note that the data type of ga:metric101 can be INTEGER, CURRENCY or TIME.")]
	public class Metric101: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric101" />.
		/// </summary>
		public Metric101(): base("Custom Metric 101 Value",true,"ga:metric101")
		{
			
		}
	}
}

