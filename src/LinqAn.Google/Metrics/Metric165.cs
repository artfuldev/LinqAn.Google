using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 165 refers the number/index of the custom metric. Note that the data type of ga:metric165 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 165 refers the number/index of the custom metric. Note that the data type of ga:metric165 can be INTEGER, CURRENCY or TIME.")]
	public class Metric165: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric165" />.
		/// </summary>
		public Metric165(): base("Custom Metric 165 Value",true,"ga:metric165")
		{
			
		}
	}
}

