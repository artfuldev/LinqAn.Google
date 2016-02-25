using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 186 refers the number/index of the custom metric. Note that the data type of ga:metric186 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 186 refers the number/index of the custom metric. Note that the data type of ga:metric186 can be INTEGER, CURRENCY or TIME.")]
	public class Metric186: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric186" />.
		/// </summary>
		public Metric186(): base("Custom Metric 186 Value",true,"ga:metric186")
		{
			
		}
	}
}

