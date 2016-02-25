using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 114 refers the number/index of the custom metric. Note that the data type of ga:metric114 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 114 refers the number/index of the custom metric. Note that the data type of ga:metric114 can be INTEGER, CURRENCY or TIME.")]
	public class Metric114: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric114" />.
		/// </summary>
		public Metric114(): base("Custom Metric 114 Value",true,"ga:metric114")
		{
			
		}
	}
}

