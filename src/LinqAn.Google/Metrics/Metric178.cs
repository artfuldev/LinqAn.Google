using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 178 refers the number/index of the custom metric. Note that the data type of ga:metric178 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 178 refers the number/index of the custom metric. Note that the data type of ga:metric178 can be INTEGER, CURRENCY or TIME.")]
	public class Metric178: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric178" />.
		/// </summary>
		public Metric178(): base("Custom Metric 178 Value",true,"ga:metric178")
		{
			
		}
	}
}

