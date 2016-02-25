using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 14 refers the number/index of the custom metric. Note that the data type of ga:metric14 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 14 refers the number/index of the custom metric. Note that the data type of ga:metric14 can be INTEGER, CURRENCY or TIME.")]
	public class Metric14: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric14" />.
		/// </summary>
		public Metric14(): base("Custom Metric 14 Value",true,"ga:metric14")
		{
			
		}
	}
}

