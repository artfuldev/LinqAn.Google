using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 169 refers the number/index of the custom metric. Note that the data type of ga:metric169 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 169 refers the number/index of the custom metric. Note that the data type of ga:metric169 can be INTEGER, CURRENCY or TIME.")]
	public class Metric169: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric169" />.
		/// </summary>
		public Metric169(): base("Custom Metric 169 Value",true,"ga:metric169")
		{
			
		}
	}
}

