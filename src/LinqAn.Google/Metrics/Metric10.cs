using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 10 refers the number/index of the custom metric. Note that the data type of ga:metric10 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 10 refers the number/index of the custom metric. Note that the data type of ga:metric10 can be INTEGER, CURRENCY or TIME.")]
	public class Metric10: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric10" />.
		/// </summary>
		public Metric10(): base("Custom Metric 10 Value",true,"ga:metric10")
		{
			
		}
	}
}

