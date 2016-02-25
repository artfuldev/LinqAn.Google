using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 17 refers the number/index of the custom metric. Note that the data type of ga:metric17 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 17 refers the number/index of the custom metric. Note that the data type of ga:metric17 can be INTEGER, CURRENCY or TIME.")]
	public class Metric17: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric17" />.
		/// </summary>
		public Metric17(): base("Custom Metric 17 Value",true,"ga:metric17")
		{
			
		}
	}
}

