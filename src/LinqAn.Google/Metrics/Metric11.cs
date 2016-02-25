using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 11 refers the number/index of the custom metric. Note that the data type of ga:metric11 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 11 refers the number/index of the custom metric. Note that the data type of ga:metric11 can be INTEGER, CURRENCY or TIME.")]
	public class Metric11: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric11" />.
		/// </summary>
		public Metric11(): base("Custom Metric 11 Value",true,"ga:metric11")
		{
			
		}
	}
}

