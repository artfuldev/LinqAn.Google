using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 68 refers the number/index of the custom metric. Note that the data type of ga:metric68 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 68 refers the number/index of the custom metric. Note that the data type of ga:metric68 can be INTEGER, CURRENCY or TIME.")]
	public class Metric68: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric68" />.
		/// </summary>
		public Metric68(): base("Custom Metric 68 Value",true,"ga:metric68")
		{
			
		}
	}
}

