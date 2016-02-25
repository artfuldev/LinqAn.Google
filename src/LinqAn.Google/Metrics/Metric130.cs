using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 130 refers the number/index of the custom metric. Note that the data type of ga:metric130 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 130 refers the number/index of the custom metric. Note that the data type of ga:metric130 can be INTEGER, CURRENCY or TIME.")]
	public class Metric130: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric130" />.
		/// </summary>
		public Metric130(): base("Custom Metric 130 Value",true,"ga:metric130")
		{
			
		}
	}
}

