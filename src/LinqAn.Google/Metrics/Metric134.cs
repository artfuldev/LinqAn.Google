using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 134 refers the number/index of the custom metric. Note that the data type of ga:metric134 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 134 refers the number/index of the custom metric. Note that the data type of ga:metric134 can be INTEGER, CURRENCY or TIME.")]
	public class Metric134: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric134" />.
		/// </summary>
		public Metric134(): base("Custom Metric 134 Value",true,"ga:metric134")
		{
			
		}
	}
}

