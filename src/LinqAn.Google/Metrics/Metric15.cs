using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 15 refers the number/index of the custom metric. Note that the data type of ga:metric15 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 15 refers the number/index of the custom metric. Note that the data type of ga:metric15 can be INTEGER, CURRENCY or TIME.")]
	public class Metric15: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric15" />.
		/// </summary>
		public Metric15(): base("Custom Metric 15 Value",true,"ga:metric15")
		{
			
		}
	}
}

