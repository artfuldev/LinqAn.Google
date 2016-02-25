using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 118 refers the number/index of the custom metric. Note that the data type of ga:metric118 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 118 refers the number/index of the custom metric. Note that the data type of ga:metric118 can be INTEGER, CURRENCY or TIME.")]
	public class Metric118: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric118" />.
		/// </summary>
		public Metric118(): base("Custom Metric 118 Value",true,"ga:metric118")
		{
			
		}
	}
}

