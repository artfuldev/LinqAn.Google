using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 192 refers the number/index of the custom metric. Note that the data type of ga:metric192 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 192 refers the number/index of the custom metric. Note that the data type of ga:metric192 can be INTEGER, CURRENCY or TIME.")]
	public class Metric192: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric192" />.
		/// </summary>
		public Metric192(): base("Custom Metric 192 Value",true,"ga:metric192")
		{
			
		}
	}
}

