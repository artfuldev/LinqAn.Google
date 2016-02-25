using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 200 refers the number/index of the custom metric. Note that the data type of ga:metric200 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 200 refers the number/index of the custom metric. Note that the data type of ga:metric200 can be INTEGER, CURRENCY or TIME.")]
	public class Metric200: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric200" />.
		/// </summary>
		public Metric200(): base("Custom Metric 200 Value",true,"ga:metric200")
		{
			
		}
	}
}

