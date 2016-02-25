using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 46 refers the number/index of the custom metric. Note that the data type of ga:metric46 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 46 refers the number/index of the custom metric. Note that the data type of ga:metric46 can be INTEGER, CURRENCY or TIME.")]
	public class Metric46: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric46" />.
		/// </summary>
		public Metric46(): base("Custom Metric 46 Value",true,"ga:metric46")
		{
			
		}
	}
}

