using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 20 refers the number/index of the custom metric. Note that the data type of ga:metric20 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 20 refers the number/index of the custom metric. Note that the data type of ga:metric20 can be INTEGER, CURRENCY or TIME.")]
	public class Metric20: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric20" />.
		/// </summary>
		public Metric20(): base("Custom Metric 20 Value",true,"ga:metric20")
		{
			
		}
	}
}

