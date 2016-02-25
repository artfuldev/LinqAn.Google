using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 9 refers the number/index of the custom metric. Note that the data type of ga:metric9 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 9 refers the number/index of the custom metric. Note that the data type of ga:metric9 can be INTEGER, CURRENCY or TIME.")]
	public class Metric9: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric9" />.
		/// </summary>
		public Metric9(): base("Custom Metric 9 Value",true,"ga:metric9")
		{
			
		}
	}
}

