using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 106 refers the number/index of the custom metric. Note that the data type of ga:metric106 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 106 refers the number/index of the custom metric. Note that the data type of ga:metric106 can be INTEGER, CURRENCY or TIME.")]
	public class Metric106: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric106" />.
		/// </summary>
		public Metric106(): base("Custom Metric 106 Value",true,"ga:metric106")
		{
			
		}
	}
}

