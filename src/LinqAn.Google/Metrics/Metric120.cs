using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 120 refers the number/index of the custom metric. Note that the data type of ga:metric120 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 120 refers the number/index of the custom metric. Note that the data type of ga:metric120 can be INTEGER, CURRENCY or TIME.")]
	public class Metric120: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric120" />.
		/// </summary>
		public Metric120(): base("Custom Metric 120 Value",true,"ga:metric120")
		{
			
		}
	}
}

