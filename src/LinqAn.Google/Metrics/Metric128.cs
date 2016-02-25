using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 128 refers the number/index of the custom metric. Note that the data type of ga:metric128 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 128 refers the number/index of the custom metric. Note that the data type of ga:metric128 can be INTEGER, CURRENCY or TIME.")]
	public class Metric128: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric128" />.
		/// </summary>
		public Metric128(): base("Custom Metric 128 Value",true,"ga:metric128")
		{
			
		}
	}
}

