using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 125 refers the number/index of the custom metric. Note that the data type of ga:metric125 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 125 refers the number/index of the custom metric. Note that the data type of ga:metric125 can be INTEGER, CURRENCY or TIME.")]
	public class Metric125: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric125" />.
		/// </summary>
		public Metric125(): base("Custom Metric 125 Value",true,"ga:metric125")
		{
			
		}
	}
}

