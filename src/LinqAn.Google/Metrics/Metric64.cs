using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 64 refers the number/index of the custom metric. Note that the data type of ga:metric64 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 64 refers the number/index of the custom metric. Note that the data type of ga:metric64 can be INTEGER, CURRENCY or TIME.")]
	public class Metric64: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric64" />.
		/// </summary>
		public Metric64(): base("Custom Metric 64 Value",true,"ga:metric64")
		{
			
		}
	}
}

