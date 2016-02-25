using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 76 refers the number/index of the custom metric. Note that the data type of ga:metric76 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 76 refers the number/index of the custom metric. Note that the data type of ga:metric76 can be INTEGER, CURRENCY or TIME.")]
	public class Metric76: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric76" />.
		/// </summary>
		public Metric76(): base("Custom Metric 76 Value",true,"ga:metric76")
		{
			
		}
	}
}

