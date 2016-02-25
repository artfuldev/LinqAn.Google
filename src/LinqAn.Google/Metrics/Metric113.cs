using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 113 refers the number/index of the custom metric. Note that the data type of ga:metric113 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 113 refers the number/index of the custom metric. Note that the data type of ga:metric113 can be INTEGER, CURRENCY or TIME.")]
	public class Metric113: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric113" />.
		/// </summary>
		public Metric113(): base("Custom Metric 113 Value",true,"ga:metric113")
		{
			
		}
	}
}

