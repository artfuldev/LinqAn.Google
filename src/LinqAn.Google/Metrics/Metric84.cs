using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 84 refers the number/index of the custom metric. Note that the data type of ga:metric84 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 84 refers the number/index of the custom metric. Note that the data type of ga:metric84 can be INTEGER, CURRENCY or TIME.")]
	public class Metric84: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric84" />.
		/// </summary>
		public Metric84(): base("Custom Metric 84 Value",true,"ga:metric84")
		{
			
		}
	}
}

