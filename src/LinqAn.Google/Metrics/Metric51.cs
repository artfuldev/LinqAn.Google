using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 51 refers the number/index of the custom metric. Note that the data type of ga:metric51 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 51 refers the number/index of the custom metric. Note that the data type of ga:metric51 can be INTEGER, CURRENCY or TIME.")]
	public class Metric51: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric51" />.
		/// </summary>
		public Metric51(): base("Custom Metric 51 Value",true,"ga:metric51")
		{
			
		}
	}
}

