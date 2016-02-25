using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 147 refers the number/index of the custom metric. Note that the data type of ga:metric147 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 147 refers the number/index of the custom metric. Note that the data type of ga:metric147 can be INTEGER, CURRENCY or TIME.")]
	public class Metric147: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric147" />.
		/// </summary>
		public Metric147(): base("Custom Metric 147 Value",true,"ga:metric147")
		{
			
		}
	}
}

