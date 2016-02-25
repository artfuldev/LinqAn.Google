using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 176 refers the number/index of the custom metric. Note that the data type of ga:metric176 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 176 refers the number/index of the custom metric. Note that the data type of ga:metric176 can be INTEGER, CURRENCY or TIME.")]
	public class Metric176: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric176" />.
		/// </summary>
		public Metric176(): base("Custom Metric 176 Value",true,"ga:metric176")
		{
			
		}
	}
}

