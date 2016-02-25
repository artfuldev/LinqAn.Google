using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 42 refers the number/index of the custom metric. Note that the data type of ga:metric42 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 42 refers the number/index of the custom metric. Note that the data type of ga:metric42 can be INTEGER, CURRENCY or TIME.")]
	public class Metric42: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric42" />.
		/// </summary>
		public Metric42(): base("Custom Metric 42 Value",true,"ga:metric42")
		{
			
		}
	}
}

