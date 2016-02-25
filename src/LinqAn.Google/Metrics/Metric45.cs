using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 45 refers the number/index of the custom metric. Note that the data type of ga:metric45 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 45 refers the number/index of the custom metric. Note that the data type of ga:metric45 can be INTEGER, CURRENCY or TIME.")]
	public class Metric45: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric45" />.
		/// </summary>
		public Metric45(): base("Custom Metric 45 Value",true,"ga:metric45")
		{
			
		}
	}
}

