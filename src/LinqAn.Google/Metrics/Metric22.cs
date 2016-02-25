using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 22 refers the number/index of the custom metric. Note that the data type of ga:metric22 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 22 refers the number/index of the custom metric. Note that the data type of ga:metric22 can be INTEGER, CURRENCY or TIME.")]
	public class Metric22: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric22" />.
		/// </summary>
		public Metric22(): base("Custom Metric 22 Value",true,"ga:metric22")
		{
			
		}
	}
}

