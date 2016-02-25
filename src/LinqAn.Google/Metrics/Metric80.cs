using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 80 refers the number/index of the custom metric. Note that the data type of ga:metric80 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 80 refers the number/index of the custom metric. Note that the data type of ga:metric80 can be INTEGER, CURRENCY or TIME.")]
	public class Metric80: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric80" />.
		/// </summary>
		public Metric80(): base("Custom Metric 80 Value",true,"ga:metric80")
		{
			
		}
	}
}

