using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 195 refers the number/index of the custom metric. Note that the data type of ga:metric195 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 195 refers the number/index of the custom metric. Note that the data type of ga:metric195 can be INTEGER, CURRENCY or TIME.")]
	public class Metric195: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric195" />.
		/// </summary>
		public Metric195(): base("Custom Metric 195 Value",true,"ga:metric195")
		{
			
		}
	}
}

