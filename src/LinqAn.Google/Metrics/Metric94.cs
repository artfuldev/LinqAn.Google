using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 94 refers the number/index of the custom metric. Note that the data type of ga:metric94 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 94 refers the number/index of the custom metric. Note that the data type of ga:metric94 can be INTEGER, CURRENCY or TIME.")]
	public class Metric94: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric94" />.
		/// </summary>
		public Metric94(): base("Custom Metric 94 Value",true,"ga:metric94")
		{
			
		}
	}
}

