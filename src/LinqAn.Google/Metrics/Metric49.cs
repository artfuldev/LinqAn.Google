using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 49 refers the number/index of the custom metric. Note that the data type of ga:metric49 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 49 refers the number/index of the custom metric. Note that the data type of ga:metric49 can be INTEGER, CURRENCY or TIME.")]
	public class Metric49: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric49" />.
		/// </summary>
		public Metric49(): base("Custom Metric 49 Value",true,"ga:metric49")
		{
			
		}
	}
}

