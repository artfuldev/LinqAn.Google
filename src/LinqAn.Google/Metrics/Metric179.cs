using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 179 refers the number/index of the custom metric. Note that the data type of ga:metric179 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 179 refers the number/index of the custom metric. Note that the data type of ga:metric179 can be INTEGER, CURRENCY or TIME.")]
	public class Metric179: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric179" />.
		/// </summary>
		public Metric179(): base("Custom Metric 179 Value",true,"ga:metric179")
		{
			
		}
	}
}

