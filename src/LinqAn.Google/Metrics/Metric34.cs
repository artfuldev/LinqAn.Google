using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 34 refers the number/index of the custom metric. Note that the data type of ga:metric34 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 34 refers the number/index of the custom metric. Note that the data type of ga:metric34 can be INTEGER, CURRENCY or TIME.")]
	public class Metric34: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric34" />.
		/// </summary>
		public Metric34(): base("Custom Metric 34 Value",true,"ga:metric34")
		{
			
		}
	}
}

