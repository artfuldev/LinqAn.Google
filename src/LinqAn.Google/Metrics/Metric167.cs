using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 167 refers the number/index of the custom metric. Note that the data type of ga:metric167 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 167 refers the number/index of the custom metric. Note that the data type of ga:metric167 can be INTEGER, CURRENCY or TIME.")]
	public class Metric167: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric167" />.
		/// </summary>
		public Metric167(): base("Custom Metric 167 Value",true,"ga:metric167")
		{
			
		}
	}
}

