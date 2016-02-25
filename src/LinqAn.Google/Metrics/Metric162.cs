using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 162 refers the number/index of the custom metric. Note that the data type of ga:metric162 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 162 refers the number/index of the custom metric. Note that the data type of ga:metric162 can be INTEGER, CURRENCY or TIME.")]
	public class Metric162: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric162" />.
		/// </summary>
		public Metric162(): base("Custom Metric 162 Value",true,"ga:metric162")
		{
			
		}
	}
}

