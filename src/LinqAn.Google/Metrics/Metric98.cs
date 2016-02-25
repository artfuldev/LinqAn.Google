using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 98 refers the number/index of the custom metric. Note that the data type of ga:metric98 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 98 refers the number/index of the custom metric. Note that the data type of ga:metric98 can be INTEGER, CURRENCY or TIME.")]
	public class Metric98: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric98" />.
		/// </summary>
		public Metric98(): base("Custom Metric 98 Value",true,"ga:metric98")
		{
			
		}
	}
}

