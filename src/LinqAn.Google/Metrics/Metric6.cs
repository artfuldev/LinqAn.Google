using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 6 refers the number/index of the custom metric. Note that the data type of ga:metric6 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 6 refers the number/index of the custom metric. Note that the data type of ga:metric6 can be INTEGER, CURRENCY or TIME.")]
	public class Metric6: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric6" />.
		/// </summary>
		public Metric6(): base("Custom Metric 6 Value",true,"ga:metric6")
		{
			
		}
	}
}

