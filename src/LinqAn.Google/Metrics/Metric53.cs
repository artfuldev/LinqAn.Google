using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 53 refers the number/index of the custom metric. Note that the data type of ga:metric53 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 53 refers the number/index of the custom metric. Note that the data type of ga:metric53 can be INTEGER, CURRENCY or TIME.")]
	public class Metric53: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric53" />.
		/// </summary>
		public Metric53(): base("Custom Metric 53 Value",true,"ga:metric53")
		{
			
		}
	}
}

