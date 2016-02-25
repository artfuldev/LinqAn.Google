using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 24 refers the number/index of the custom metric. Note that the data type of ga:metric24 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 24 refers the number/index of the custom metric. Note that the data type of ga:metric24 can be INTEGER, CURRENCY or TIME.")]
	public class Metric24: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric24" />.
		/// </summary>
		public Metric24(): base("Custom Metric 24 Value",true,"ga:metric24")
		{
			
		}
	}
}

