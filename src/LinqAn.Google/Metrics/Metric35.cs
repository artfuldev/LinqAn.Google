using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 35 refers the number/index of the custom metric. Note that the data type of ga:metric35 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 35 refers the number/index of the custom metric. Note that the data type of ga:metric35 can be INTEGER, CURRENCY or TIME.")]
	public class Metric35: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric35" />.
		/// </summary>
		public Metric35(): base("Custom Metric 35 Value",true,"ga:metric35")
		{
			
		}
	}
}

