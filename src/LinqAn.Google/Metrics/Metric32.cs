using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 32 refers the number/index of the custom metric. Note that the data type of ga:metric32 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 32 refers the number/index of the custom metric. Note that the data type of ga:metric32 can be INTEGER, CURRENCY or TIME.")]
	public class Metric32: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric32" />.
		/// </summary>
		public Metric32(): base("Custom Metric 32 Value",true,"ga:metric32")
		{
			
		}
	}
}

