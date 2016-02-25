using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 36 refers the number/index of the custom metric. Note that the data type of ga:metric36 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 36 refers the number/index of the custom metric. Note that the data type of ga:metric36 can be INTEGER, CURRENCY or TIME.")]
	public class Metric36: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric36" />.
		/// </summary>
		public Metric36(): base("Custom Metric 36 Value",true,"ga:metric36")
		{
			
		}
	}
}

