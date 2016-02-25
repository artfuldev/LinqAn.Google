using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 91 refers the number/index of the custom metric. Note that the data type of ga:metric91 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 91 refers the number/index of the custom metric. Note that the data type of ga:metric91 can be INTEGER, CURRENCY or TIME.")]
	public class Metric91: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric91" />.
		/// </summary>
		public Metric91(): base("Custom Metric 91 Value",true,"ga:metric91")
		{
			
		}
	}
}

