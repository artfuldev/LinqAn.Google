using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 188 refers the number/index of the custom metric. Note that the data type of ga:metric188 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 188 refers the number/index of the custom metric. Note that the data type of ga:metric188 can be INTEGER, CURRENCY or TIME.")]
	public class Metric188: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric188" />.
		/// </summary>
		public Metric188(): base("Custom Metric 188 Value",true,"ga:metric188")
		{
			
		}
	}
}

