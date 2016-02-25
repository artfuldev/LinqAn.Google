using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 82 refers the number/index of the custom metric. Note that the data type of ga:metric82 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 82 refers the number/index of the custom metric. Note that the data type of ga:metric82 can be INTEGER, CURRENCY or TIME.")]
	public class Metric82: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric82" />.
		/// </summary>
		public Metric82(): base("Custom Metric 82 Value",true,"ga:metric82")
		{
			
		}
	}
}

