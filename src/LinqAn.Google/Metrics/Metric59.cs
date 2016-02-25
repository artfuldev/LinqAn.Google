using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 59 refers the number/index of the custom metric. Note that the data type of ga:metric59 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 59 refers the number/index of the custom metric. Note that the data type of ga:metric59 can be INTEGER, CURRENCY or TIME.")]
	public class Metric59: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric59" />.
		/// </summary>
		public Metric59(): base("Custom Metric 59 Value",true,"ga:metric59")
		{
			
		}
	}
}

