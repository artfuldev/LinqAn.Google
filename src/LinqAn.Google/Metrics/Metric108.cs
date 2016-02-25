using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 108 refers the number/index of the custom metric. Note that the data type of ga:metric108 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 108 refers the number/index of the custom metric. Note that the data type of ga:metric108 can be INTEGER, CURRENCY or TIME.")]
	public class Metric108: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric108" />.
		/// </summary>
		public Metric108(): base("Custom Metric 108 Value",true,"ga:metric108")
		{
			
		}
	}
}

