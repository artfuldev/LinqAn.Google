using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 181 refers the number/index of the custom metric. Note that the data type of ga:metric181 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 181 refers the number/index of the custom metric. Note that the data type of ga:metric181 can be INTEGER, CURRENCY or TIME.")]
	public class Metric181: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric181" />.
		/// </summary>
		public Metric181(): base("Custom Metric 181 Value",true,"ga:metric181")
		{
			
		}
	}
}

