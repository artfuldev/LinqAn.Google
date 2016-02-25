using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 138 refers the number/index of the custom metric. Note that the data type of ga:metric138 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 138 refers the number/index of the custom metric. Note that the data type of ga:metric138 can be INTEGER, CURRENCY or TIME.")]
	public class Metric138: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric138" />.
		/// </summary>
		public Metric138(): base("Custom Metric 138 Value",true,"ga:metric138")
		{
			
		}
	}
}

