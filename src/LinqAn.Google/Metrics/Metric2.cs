using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 2 refers the number/index of the custom metric. Note that the data type of ga:metric2 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 2 refers the number/index of the custom metric. Note that the data type of ga:metric2 can be INTEGER, CURRENCY or TIME.")]
	public class Metric2: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric2" />.
		/// </summary>
		public Metric2(): base("Custom Metric 2 Value",true,"ga:metric2")
		{
			
		}
	}
}

