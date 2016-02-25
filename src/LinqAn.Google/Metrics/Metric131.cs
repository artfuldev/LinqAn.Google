using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 131 refers the number/index of the custom metric. Note that the data type of ga:metric131 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 131 refers the number/index of the custom metric. Note that the data type of ga:metric131 can be INTEGER, CURRENCY or TIME.")]
	public class Metric131: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric131" />.
		/// </summary>
		public Metric131(): base("Custom Metric 131 Value",true,"ga:metric131")
		{
			
		}
	}
}

