using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 30 refers the number/index of the custom metric. Note that the data type of ga:metric30 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 30 refers the number/index of the custom metric. Note that the data type of ga:metric30 can be INTEGER, CURRENCY or TIME.")]
	public class Metric30: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric30" />.
		/// </summary>
		public Metric30(): base("Custom Metric 30 Value",true,"ga:metric30")
		{
			
		}
	}
}

