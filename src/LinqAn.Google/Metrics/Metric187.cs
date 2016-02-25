using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 187 refers the number/index of the custom metric. Note that the data type of ga:metric187 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 187 refers the number/index of the custom metric. Note that the data type of ga:metric187 can be INTEGER, CURRENCY or TIME.")]
	public class Metric187: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric187" />.
		/// </summary>
		public Metric187(): base("Custom Metric 187 Value",true,"ga:metric187")
		{
			
		}
	}
}

