using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 197 refers the number/index of the custom metric. Note that the data type of ga:metric197 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 197 refers the number/index of the custom metric. Note that the data type of ga:metric197 can be INTEGER, CURRENCY or TIME.")]
	public class Metric197: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric197" />.
		/// </summary>
		public Metric197(): base("Custom Metric 197 Value",true,"ga:metric197")
		{
			
		}
	}
}

