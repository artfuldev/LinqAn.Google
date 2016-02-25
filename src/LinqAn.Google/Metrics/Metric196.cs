using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 196 refers the number/index of the custom metric. Note that the data type of ga:metric196 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 196 refers the number/index of the custom metric. Note that the data type of ga:metric196 can be INTEGER, CURRENCY or TIME.")]
	public class Metric196: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric196" />.
		/// </summary>
		public Metric196(): base("Custom Metric 196 Value",true,"ga:metric196")
		{
			
		}
	}
}

