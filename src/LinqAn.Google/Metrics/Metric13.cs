using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 13 refers the number/index of the custom metric. Note that the data type of ga:metric13 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 13 refers the number/index of the custom metric. Note that the data type of ga:metric13 can be INTEGER, CURRENCY or TIME.")]
	public class Metric13: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric13" />.
		/// </summary>
		public Metric13(): base("Custom Metric 13 Value",true,"ga:metric13")
		{
			
		}
	}
}

