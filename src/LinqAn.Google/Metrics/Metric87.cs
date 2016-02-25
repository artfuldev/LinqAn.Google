using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 87 refers the number/index of the custom metric. Note that the data type of ga:metric87 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 87 refers the number/index of the custom metric. Note that the data type of ga:metric87 can be INTEGER, CURRENCY or TIME.")]
	public class Metric87: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric87" />.
		/// </summary>
		public Metric87(): base("Custom Metric 87 Value",true,"ga:metric87")
		{
			
		}
	}
}

