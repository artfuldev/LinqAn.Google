using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 129 refers the number/index of the custom metric. Note that the data type of ga:metric129 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 129 refers the number/index of the custom metric. Note that the data type of ga:metric129 can be INTEGER, CURRENCY or TIME.")]
	public class Metric129: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric129" />.
		/// </summary>
		public Metric129(): base("Custom Metric 129 Value",true,"ga:metric129")
		{
			
		}
	}
}

