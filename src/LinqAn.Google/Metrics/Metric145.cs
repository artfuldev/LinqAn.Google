using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 145 refers the number/index of the custom metric. Note that the data type of ga:metric145 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 145 refers the number/index of the custom metric. Note that the data type of ga:metric145 can be INTEGER, CURRENCY or TIME.")]
	public class Metric145: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric145" />.
		/// </summary>
		public Metric145(): base("Custom Metric 145 Value",true,"ga:metric145")
		{
			
		}
	}
}

