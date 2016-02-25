using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 3 refers the number/index of the custom metric. Note that the data type of ga:metric3 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 3 refers the number/index of the custom metric. Note that the data type of ga:metric3 can be INTEGER, CURRENCY or TIME.")]
	public class Metric3: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric3" />.
		/// </summary>
		public Metric3(): base("Custom Metric 3 Value",true,"ga:metric3")
		{
			
		}
	}
}

