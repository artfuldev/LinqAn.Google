using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 93 refers the number/index of the custom metric. Note that the data type of ga:metric93 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 93 refers the number/index of the custom metric. Note that the data type of ga:metric93 can be INTEGER, CURRENCY or TIME.")]
	public class Metric93: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric93" />.
		/// </summary>
		public Metric93(): base("Custom Metric 93 Value",true,"ga:metric93")
		{
			
		}
	}
}

