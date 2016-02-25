using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 56 refers the number/index of the custom metric. Note that the data type of ga:metric56 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 56 refers the number/index of the custom metric. Note that the data type of ga:metric56 can be INTEGER, CURRENCY or TIME.")]
	public class Metric56: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric56" />.
		/// </summary>
		public Metric56(): base("Custom Metric 56 Value",true,"ga:metric56")
		{
			
		}
	}
}

