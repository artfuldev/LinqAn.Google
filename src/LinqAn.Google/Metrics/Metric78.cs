using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 78 refers the number/index of the custom metric. Note that the data type of ga:metric78 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 78 refers the number/index of the custom metric. Note that the data type of ga:metric78 can be INTEGER, CURRENCY or TIME.")]
	public class Metric78: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric78" />.
		/// </summary>
		public Metric78(): base("Custom Metric 78 Value",true,"ga:metric78")
		{
			
		}
	}
}

