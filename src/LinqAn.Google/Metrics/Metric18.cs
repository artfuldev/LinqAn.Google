using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 18 refers the number/index of the custom metric. Note that the data type of ga:metric18 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 18 refers the number/index of the custom metric. Note that the data type of ga:metric18 can be INTEGER, CURRENCY or TIME.")]
	public class Metric18: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric18" />.
		/// </summary>
		public Metric18(): base("Custom Metric 18 Value",true,"ga:metric18")
		{
			
		}
	}
}

