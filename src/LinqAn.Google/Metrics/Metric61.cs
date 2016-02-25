using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 61 refers the number/index of the custom metric. Note that the data type of ga:metric61 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 61 refers the number/index of the custom metric. Note that the data type of ga:metric61 can be INTEGER, CURRENCY or TIME.")]
	public class Metric61: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric61" />.
		/// </summary>
		public Metric61(): base("Custom Metric 61 Value",true,"ga:metric61")
		{
			
		}
	}
}

