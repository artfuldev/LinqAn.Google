using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 16 refers the number/index of the custom metric. Note that the data type of ga:metric16 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 16 refers the number/index of the custom metric. Note that the data type of ga:metric16 can be INTEGER, CURRENCY or TIME.")]
	public class Metric16: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric16" />.
		/// </summary>
		public Metric16(): base("Custom Metric 16 Value",true,"ga:metric16")
		{
			
		}
	}
}

