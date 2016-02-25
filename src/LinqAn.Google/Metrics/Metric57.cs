using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 57 refers the number/index of the custom metric. Note that the data type of ga:metric57 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 57 refers the number/index of the custom metric. Note that the data type of ga:metric57 can be INTEGER, CURRENCY or TIME.")]
	public class Metric57: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric57" />.
		/// </summary>
		public Metric57(): base("Custom Metric 57 Value",true,"ga:metric57")
		{
			
		}
	}
}

