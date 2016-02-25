using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 25 refers the number/index of the custom metric. Note that the data type of ga:metric25 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 25 refers the number/index of the custom metric. Note that the data type of ga:metric25 can be INTEGER, CURRENCY or TIME.")]
	public class Metric25: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric25" />.
		/// </summary>
		public Metric25(): base("Custom Metric 25 Value",true,"ga:metric25")
		{
			
		}
	}
}

