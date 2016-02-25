using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 112 refers the number/index of the custom metric. Note that the data type of ga:metric112 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 112 refers the number/index of the custom metric. Note that the data type of ga:metric112 can be INTEGER, CURRENCY or TIME.")]
	public class Metric112: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric112" />.
		/// </summary>
		public Metric112(): base("Custom Metric 112 Value",true,"ga:metric112")
		{
			
		}
	}
}

