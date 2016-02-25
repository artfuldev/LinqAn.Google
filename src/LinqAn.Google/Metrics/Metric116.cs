using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 116 refers the number/index of the custom metric. Note that the data type of ga:metric116 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 116 refers the number/index of the custom metric. Note that the data type of ga:metric116 can be INTEGER, CURRENCY or TIME.")]
	public class Metric116: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric116" />.
		/// </summary>
		public Metric116(): base("Custom Metric 116 Value",true,"ga:metric116")
		{
			
		}
	}
}

