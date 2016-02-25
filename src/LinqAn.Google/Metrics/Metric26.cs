using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 26 refers the number/index of the custom metric. Note that the data type of ga:metric26 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 26 refers the number/index of the custom metric. Note that the data type of ga:metric26 can be INTEGER, CURRENCY or TIME.")]
	public class Metric26: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric26" />.
		/// </summary>
		public Metric26(): base("Custom Metric 26 Value",true,"ga:metric26")
		{
			
		}
	}
}

