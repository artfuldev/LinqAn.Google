using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 29 refers the number/index of the custom metric. Note that the data type of ga:metric29 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 29 refers the number/index of the custom metric. Note that the data type of ga:metric29 can be INTEGER, CURRENCY or TIME.")]
	public class Metric29: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric29" />.
		/// </summary>
		public Metric29(): base("Custom Metric 29 Value",true,"ga:metric29")
		{
			
		}
	}
}

