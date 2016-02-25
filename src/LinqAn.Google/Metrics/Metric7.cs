using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 7 refers the number/index of the custom metric. Note that the data type of ga:metric7 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 7 refers the number/index of the custom metric. Note that the data type of ga:metric7 can be INTEGER, CURRENCY or TIME.")]
	public class Metric7: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric7" />.
		/// </summary>
		public Metric7(): base("Custom Metric 7 Value",true,"ga:metric7")
		{
			
		}
	}
}

