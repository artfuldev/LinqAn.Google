using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 38 refers the number/index of the custom metric. Note that the data type of ga:metric38 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 38 refers the number/index of the custom metric. Note that the data type of ga:metric38 can be INTEGER, CURRENCY or TIME.")]
	public class Metric38: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric38" />.
		/// </summary>
		public Metric38(): base("Custom Metric 38 Value",true,"ga:metric38")
		{
			
		}
	}
}

