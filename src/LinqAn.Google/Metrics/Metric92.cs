using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 92 refers the number/index of the custom metric. Note that the data type of ga:metric92 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 92 refers the number/index of the custom metric. Note that the data type of ga:metric92 can be INTEGER, CURRENCY or TIME.")]
	public class Metric92: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric92" />.
		/// </summary>
		public Metric92(): base("Custom Metric 92 Value",true,"ga:metric92")
		{
			
		}
	}
}

