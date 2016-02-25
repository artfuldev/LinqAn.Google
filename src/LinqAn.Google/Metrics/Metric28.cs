using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 28 refers the number/index of the custom metric. Note that the data type of ga:metric28 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 28 refers the number/index of the custom metric. Note that the data type of ga:metric28 can be INTEGER, CURRENCY or TIME.")]
	public class Metric28: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric28" />.
		/// </summary>
		public Metric28(): base("Custom Metric 28 Value",true,"ga:metric28")
		{
			
		}
	}
}

